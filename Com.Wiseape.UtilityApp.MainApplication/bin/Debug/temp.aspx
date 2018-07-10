<%
	DataSourceTable table = (DataSourceTable)Module.Datasource;
	string tableName = table.TableName;
	string keyColumnName = table.KeyColumn.ColumnName;
	string keyColumnVar = StrUtil.LowFirst(keyColumnName);
	
	DataSourceUITable uiTable = (DataSourceUITable)Module.ModelType.Datasource;
	
	string json = Com.Wiseape.Utility.Serializer.Json.Serialize(Module.UIObjects);
	json = json.Replace("TableCells", "Cells");
	json = json.Replace("TableCellName", "Name");
	me.say(json);
%>