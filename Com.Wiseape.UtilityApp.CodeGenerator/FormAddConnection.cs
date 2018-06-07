using Microsoft.Data.ConnectionUI;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;

namespace Com.Wiseape.UtilityApp.CodeGenerator
{
    public partial class FormAddConnection : Form
    {
        public bool IsCanceled { get; set; }
        public SavedConnection SavedConnection { get; set; }

        public FormAddConnection()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.IsCanceled = true;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.SavedConnection = new SavedConnection();
            this.SavedConnection.ConnectionName = txtConnectionName.Text;
            this.SavedConnection.ConnectionString = txtConnectionString.Text;
            this.IsCanceled = false;
            this.Close();
        }

        bool CreateConnectionDialog(out string outConnectionString)
        {
            using (var dialog = new DataConnectionDialog())
            {
                // If you want the user to select from any of the available data sources, do this:
                DataSource.AddStandardDataSources(dialog);

                // OR, if you want only certain data sources to be available
                // (e.g. only SQL Server), do something like this instead: 
                dialog.DataSources.Add(DataSource.SqlDataSource);
                dialog.DataSources.Add(DataSource.SqlFileDataSource);


                // The way how you show the dialog is somewhat unorthodox; `dialog.ShowDialog()`
                // would throw a `NotSupportedException`. Do it this way instead:
                DialogResult userChoice = DataConnectionDialog.Show(dialog);

                        // Return the resulting connection string if a connection was selected:
                        if (userChoice == DialogResult.OK)
                        {
                            outConnectionString = dialog.ConnectionString;
                            return true;
                        }
                        else
                        {
                            outConnectionString = null;
                            return false;
                        }
                    }
        }

        private void btnCreateConnection_Click(object sender, EventArgs e)
        {
            string conString = "";
            bool result = CreateConnectionDialog(out conString);
            if(result)
            {
                txtConnectionString.Text = conString;
            }
        }
    }
}
