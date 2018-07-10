using Com.Wiseape.UtilityApp.CodeGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.UtilityApp.CodeGenerator.Ctrls.Elements
{
    [Serializable]
    public class FileUploadPropertyPage : PropertyPage
    {
        public FileUploadPropertyPage()
        {
            this.Properties.Add("UploadUrl", "{{url}}/upload");
            this.PropertyConfigurator = new FileUploadConfigurator(this);
            this.Drawer = new FileUploadDrawer(this);

        }

        public override string GetElementName()
        {
            return "File Upload";
        }

        public override string GetElementID()
        {
            return Settings.Default.FILEUPLOAD;
        }

        public override Image GetIcon()
        {
            return (Image) Resources.cloud_upload_arrow;
        }

        public override PropertyPage CreateNew(int idx = 0)
        {
            PropertyPage p = new FileUploadPropertyPage();
            p.Properties["ID"] = "FileUpload" + idx;
            return p;
        }
    }
}
