using Com.Wiseape.FactoryConfigurator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Wiseape.UtilityApp.FactoryConfigurator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            FormSessionName frm = new FormSessionName();
            frm.ConfigFile = txtFile.Text;
            frm.ShowDialog();

            if(frm.IsCanceled == false)
            {
                InitComboSession();
                RefreshSession(frm.SavedSession.SessionName);
            }

        }

        void InitComboSession()
        {
            DontRunEvent = true;
            SessionList list = GetSessionList();
            cmbSession.DataSource = list.Sessions;
            cmbSession.DisplayMember = "SessionName";
            cmbSession.ValueMember = "SessionName";
            DontRunEvent = false;

        }

        void RefreshSession(string sessionName)
        {
            cmbSession.SelectedValue = sessionName;

            DisplaySession((SavedSession)cmbSession.SelectedItem);

        }

        void DisplaySession(SavedSession session)
        {
            if(session != null)
                txtFile.Text = session.ConfigFile;
        }

        void DeleteSession()
        {
            string sessionName = (string)cmbSession.SelectedValue;
            SessionList list = GetSessionList();
            foreach(SavedSession session in list.Sessions)
            {
                if(session.SessionName == sessionName)
                {
                    list.Sessions.Remove(session);
                    break;
                }
            }
            SaveSessionList(list);
            InitComboSession();
        }

        SessionList GetSessionList()
        {
            string xml = System.IO.File.ReadAllText(System.IO.Directory.GetCurrentDirectory() + "/SavedSessions.dat");
            SessionList sessionList = Utility.Serializer.XML.Deserialize<SessionList>(xml);
            return sessionList;
        }

        void SaveSessionList(SessionList list)
        {
            string xml = Utility.Serializer.XML.Serialize(list);
            System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "/SavedSessions.dat", xml);
        }

        private void btnDeleteSession_Click(object sender, EventArgs e)
        {
            DeleteSession();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileOk += Dialog_FileOk;
            dialog.ShowDialog();

            
        }

        private void Dialog_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dialog = (OpenFileDialog)sender;
            string filename = dialog.FileName;
            txtFile.Text = filename;
        }

        List<FactoryConfigurationItem> GetFactoryConfigurationItemFromFile()
        {
            string filename = txtFile.Text;
            string content = System.IO.File.ReadAllText(filename);
            List<FactoryConfigurationItem> configItems = (List<FactoryConfigurationItem>)Utility.Serializer.XML.Deserialize<List<FactoryConfigurationItem>>(content);
            return configItems;
        }


        void OpenFileAndDisplay(string filename)
        {
            string content = System.IO.File.ReadAllText(filename);
            List<FactoryConfigurationItem> configItems = (List<FactoryConfigurationItem>)Utility.Serializer.XML.Deserialize<List<FactoryConfigurationItem>>(content);
            DisplayAll(configItems);
        }

        void DisplayAll(List<FactoryConfigurationItem> items)
        {
            gridList.DataSource = items;
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            txtKey.Text = "";
            List<FactoryConfigurationItem> items = GetFactoryConfigurationItems();
            SaveList(items);
        }

        List<FactoryConfigurationItem> GetFactoryConfigurationItems()
        {
            List<FactoryConfigurationItem> items = (List<FactoryConfigurationItem>)gridList.DataSource;
            return items;
        }

        void SaveList(List<FactoryConfigurationItem> items)
        {
            string xml = Utility.Serializer.XML.Serialize(items);
            string filename = txtFile.Text;
            System.IO.File.WriteAllText(filename, xml);

            OpenFileAndDisplay(filename);
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            List<FactoryConfigurationItem> searchedItems = new List<FactoryConfigurationItem>();
            List < FactoryConfigurationItem > items = GetFactoryConfigurationItemFromFile();
            foreach(FactoryConfigurationItem item in items)
            {
                if(item.Key.ToLower().Contains(txtKey.Text.ToLower()))
                    searchedItems.Add(item);
            }
            DisplayAll(searchedItems);
        }

        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            FormAddConfiguration frm = new FormAddConfiguration();
            frm.ShowDialog();
            if(frm.item != null)
            {
                FactoryConfigurationItem item = frm.item;
                List<FactoryConfigurationItem> items = GetFactoryConfigurationItemFromFile();
                items.Add(item);
                SaveList(items);

                OpenFileAndDisplay(txtFile.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FactoryConfigurationItem selectedItem = null;
            string key = (string)gridList.SelectedRows[0].Cells[ColKey.Name].Value;
            List<FactoryConfigurationItem> items = GetFactoryConfigurationItemFromFile();
            foreach (FactoryConfigurationItem item in items)
            {
                if (item.Key == key)
                {
                    selectedItem = item;

                }

            }

            if (selectedItem != null)
            {
                items.Remove(selectedItem);
                SaveList(items);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FactoryConfigurationItem item = new FactoryConfigurationItem();
            item.Key = "test";
            item.ClassInfo = "dsfas";
            item.ClassName = "asdfa";
            item.DllName = "sadfasdf";

            List<FactoryConfigurationItem> items = new List<FactoryConfigurationItem>();
            items.Add(item);
            string xml = Utility.Serializer.XML.Serialize(items);
            //System.IO.File.WriteAllText("test.dat", xml);

            SessionList list = new SessionList();
            SavedSession session = new SavedSession();
            session.ConfigFile = System.IO.Directory.GetCurrentDirectory() + "/test.dat";
            session.CreatedDate = DateTime.Now;
            session.SessionName = "Test";

            list.Sessions.Add(session);
            xml = Utility.Serializer.XML.Serialize(list);
            //System.IO.File.WriteAllText("SavedSessions.dat", xml);
            InitComboSession();
            LoadSessions();
            this.WindowState = FormWindowState.Maximized;
        }

        void LoadSessions()
        {
            RefreshSession("");
            /*
            string filename = "SavedSessions.dat";
            string xml = System.IO.File.ReadAllText(filename);
            SessionList list = (SessionList)Utility.Serializer.XML.Deserialize<SessionList>(xml);
            cmbSession.DataSource = list;*/

        }

        private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            OpenFileAndDisplay(txtFile.Text);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            gridList.Width = this.Width - 40;
            gridList.Height = this.Height - gridList.Top - 40;
        }

        private void cmbSession_SelectedValueChanged(object sender, EventArgs e)
        {
            if(DontRunEvent == false)
            {
                if (Convert.ToString(cmbSession.SelectedValue) != "" && cmbSession.SelectedValue != null && cmbSession.SelectedValue.GetType() != typeof(SavedSession))
                {
                    RefreshSession(((SavedSession)cmbSession.SelectedItem).SessionName);
                    DontRunEvent = false;
                }

            }

        }

        bool DontRunEvent = false;
        private void cmbSession_DataSourceChanged(object sender, EventArgs e)
        {
        }
    }
}
