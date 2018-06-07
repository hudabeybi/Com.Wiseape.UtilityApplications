using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;
using System.Data.SqlClient;
using System.Data;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Business
{
    public class SqlServerSchema
    {
        public List<DataSourceTable> GetTables(string connectionString)
        {
            List<DataSourceTable> tables = new List<DataSourceTable>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

              

                // First, get schema information of all the tables in current database;
                DataTable allTablesSchemaTable = conn.GetSchema("Tables");
               

                Console.WriteLine("Schema Information of All Tables:");
                ShowDataTable(allTablesSchemaTable, 20);
                Console.WriteLine();

                foreach(DataRow row in allTablesSchemaTable.Rows)
                {
                    DataSourceTable tbl = new DataSourceTable();
                    tbl.TableName = Convert.ToString(row["TABLE_NAME"]);
                    tbl.TableSchema = Convert.ToString(row["TABLE_SCHEMA"]);

                    // You can specify the Catalog, Schema, Table Name, Constraint Name, Column Name to 
                    // get the specified column(s).
                    // You can use five restrictions for Column, so you should create a 5 members array.
                    String[] indexColumnsRestrictions = new String[5];

                    // For the array, 0-member represents Catalog; 1-member represents Schema; 
                    // 2-member represents Table Name; 3-member represents Constraint Name;4-member represents Column Name. 
                    // Now we specify the Table_Name and Column_Name of the columns what we want to get schema information.
                    indexColumnsRestrictions[2] = Convert.ToString(row["TABLE_SCHEMA"]);
                    indexColumnsRestrictions[2] = Convert.ToString(row["TABLE_NAME"]);

                    DataTable courseIdIndexSchemaTable = conn.GetSchema("IndexColumns", indexColumnsRestrictions);
                    List<string> ss = new List<string>();
                    foreach(DataRow idxRow in courseIdIndexSchemaTable.Rows)
                    {
                        ss.Add(Convert.ToString( idxRow["column_name"]));
                    }


                    // You can specify the Catalog, Schema, Table Name, Column Name to get the specified column(s).
                    // You can use four restrictions for Column, so you should create a 4 members array.
                    String[] columnRestrictionss = new String[4];

                    // For the array, 0-member represents Catalog; 1-member represents Schema; 
                    // 2-member represents Table Name; 3-member represents Column Name. 
                    // Now we specify the Table_Name and Column_Name of the columns what we want to get schema information.
                    columnRestrictionss[1] = Convert.ToString(row["TABLE_SCHEMA"]);
                    columnRestrictionss[2] = Convert.ToString( row["TABLE_NAME"]);


                    DataTable schemaTableColumns = conn.GetSchema("Columns", columnRestrictionss);
                    foreach(DataRow colRow in schemaTableColumns.Rows)
                    {
                        Model.DataColumn column = new Model.DataColumn();
                        column.ColumnName = Convert.ToString(colRow["COLUMN_NAME"]);
                        column.DataType = Convert.ToString(colRow["DATA_TYPE"]);
                        if (ss.Contains(column.ColumnName))
                            column.Key = true;
                        else
                            column.Key = false;

                        tbl.DataColumns.Add(column);
                    }

                    tables.Add(tbl);

                }


            }

            return tables;
        }

        private void ShowDataTable(DataTable table, Int32 length)
        {
            foreach (System.Data.DataColumn col in table.Columns)
            {
                Console.Write("{0,-" + length + "}", col.ColumnName);
            }
            Console.WriteLine();

            foreach (DataRow row in table.Rows)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    if (col.DataType.Equals(typeof(DateTime)))
                        Console.Write("{0,-" + length + ":d}", row[col]);
                    else if (col.DataType.Equals(typeof(Decimal)))
                        Console.Write("{0,-" + length + ":C}", row[col]);
                    else
                        Console.Write("{0,-" + length + "}", row[col]);
                }
                Console.WriteLine();
            }
        }

        private void ShowDataTable(DataTable table)
        {
            ShowDataTable(table, 14);
        }

        private void ShowColumns(DataTable columnsTable)
        {
            var selectedRows = from info in columnsTable.AsEnumerable()
                               select new
                               {
                                   TableCatalog = info["TABLE_CATALOG"],
                                   TableSchema = info["TABLE_SCHEMA"],
                                   TableName = info["TABLE_NAME"],
                                   ColumnName = info["COLUMN_NAME"],
                                   DataType = info["DATA_TYPE"]
                               };

            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", "TableCatalog", "TABLE_SCHEMA",
                "TABLE_NAME", "COLUMN_NAME", "DATA_TYPE");
            foreach (var row in selectedRows)
            {
                Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", row.TableCatalog,
                    row.TableSchema, row.TableName, row.ColumnName, row.DataType);
            }
        }

        private void ShowIndexColumns(DataTable indexColumnsTable)
        {
            var selectedRows = from info in indexColumnsTable.AsEnumerable()
                               select new
                               {
                                   TableSchema = info["table_schema"],
                                   TableName = info["table_name"],
                                   ColumnName = info["column_name"],
                                   ConstraintSchema = info["constraint_schema"],
                                   ConstraintName = info["constraint_name"],
                                   KeyType = info["KeyType"]
                               };

            Console.WriteLine("{0,-14}{1,-11}{2,-14}{3,-18}{4,-16}{5,-8}", "table_schema", "table_name", "column_name", "constraint_schema", "constraint_name", "KeyType");
            foreach (var row in selectedRows)
            {
                Console.WriteLine("{0,-14}{1,-11}{2,-14}{3,-18}{4,-16}{5,-8}", row.TableSchema,
                    row.TableName, row.ColumnName, row.ConstraintSchema, row.ConstraintName, row.KeyType);
            }
        }
    }
}
