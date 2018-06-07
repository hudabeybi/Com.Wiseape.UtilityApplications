using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Wiseape.FactoryConfigurator.Model;
using Com.Wiseape.Utility;

namespace Com.Wiseape.UtilityApp.FactoryConfigurator
{
    public partial class FormSessionName : Form
    {
        public bool IsCanceled { get; set; }
        public SavedSession SavedSession { get; set; }
        public FormSessionName()
        {
            InitializeComponent();
        }
        public string ConfigFile { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SavedSession session = new SavedSession();
            session.CreatedDate = DateTime.Now;
            session.SessionName = txtSessionName.Text;
            session.ConfigFile = this.ConfigFile;

            SessionList list = GetSessionList();
            list.Sessions.Add(session);

            SaveSessionList(list);
            this.IsCanceled = false;
            SavedSession = session;
            this.Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.IsCanceled = true;
            this.Close();
        }
    }
}
