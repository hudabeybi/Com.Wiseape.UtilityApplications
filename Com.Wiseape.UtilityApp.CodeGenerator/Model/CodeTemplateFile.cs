using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Model
{
    public class CodeTemplateFile
    {
        private string mFileName;
        private string mResultFileName;
        private string mDescription;
        private bool mProjectTemplate;
        private bool mReplace;

        public string FileName
        {
            get { return this.mFileName; }
            set { this.mFileName = value; }
        }

        public bool Replace
        {
            get { if (mReplace == null) mReplace = true; return this.mReplace; }
            set { this.mReplace = value; }
        }

        public string ResultFileName
        {
            get { return this.mResultFileName; }
            set { this.mResultFileName = value; }
        }

        public string Description
        {
            get { return this.mDescription; }
            set { this.mDescription = value; }
        }

        public bool ProjectTemplate
        {
            get { return this.mProjectTemplate; }
            set { this.mProjectTemplate = value; }
        }


    }
}
