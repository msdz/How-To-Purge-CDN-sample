using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CDN_Pruge_ClientApp
{
    public partial class PrugeForm : Form
    {
        public PrugeForm()
        {
            InitializeComponent();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            var path = string.Empty;
            var saveFile = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = @"txt files (*.txt)|*.txt",
                FileName = DateTime.Now.ToString("yyyyMMdd") + "_" + "PurgeResource.txt"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                path = saveFile.FileName;
                using (var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
                {
                    var json = JsonConvert.SerializeObject(GetPurgeInfo());
                    var formatJson = ConvertJsonString(json);
                    var sW = new StreamWriter(fileStream, Encoding.UTF8);
                    sW.Write(formatJson);
                    sW.Close();
                }
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = @"txt files (*.txt)|*.txt"
            }; 
            if (openFile.ShowDialog() != DialogResult.OK) return;
            var path = openFile.FileName;
            try
            {
                string txtJson;
                using (var fS = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    var sR = new StreamReader(fS, Encoding.UTF8);
                    txtJson = sR.ReadToEnd();
                    sR.Close();
                }
                var result = JsonConvert.DeserializeObject<PurgeHelper.PurgeModel>(txtJson);
                txtClientId.Text = result.ClientId;
                txtClientSecret.Text = result.ClientSecret;
                txtSubscriptions.Text = result.Subscriptions;
                txtResourceGroup.Text = result.ResourceGroup;
                txtCdnProfile.Text = result.CdnProfile;
                txtCdnEndpoint.Text = result.CdnEndpoint;
                txtActiveDirectory.Text = result.ActiveDirectory;
                txtPurgeList.Text = ListToString(result.PurgeList);
                MessageBox.Show(@"File Load Successful!");
            }
            catch (Exception)
            {
                MessageBox.Show(@"File Load Failed! Please check the file format!");
                throw;
            }
        }

        private string ConvertJsonString(string str)
        {
            var serializer = new JsonSerializer();
            var tr = new StringReader(str);
            var jtr = new JsonTextReader(tr);
            var obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                var textWriter = new StringWriter();
                var jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }

        public PurgeHelper.PurgeModel GetPurgeInfo()
        {
            return new PurgeHelper.PurgeModel()
            {
                ClientId = txtClientId.Text,
                ClientSecret = txtClientSecret.Text,
                Subscriptions = txtSubscriptions.Text,
                ResourceGroup = txtResourceGroup.Text,
                CdnProfile = txtCdnProfile.Text,
                CdnEndpoint = txtCdnEndpoint.Text,
                ActiveDirectory = txtActiveDirectory.Text,
                PurgeList = StringToList(txtPurgeList.Text),
            };
        }

        public List<string> StringToList(string txt)
        {
            return txt.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }

        public string ListToString(List<string> list)
        {
            return string.Join(Environment.NewLine, list);
        }

        private void btnPurge_Click(object sender, EventArgs e)
        {
            var result = PurgeHelper.GetAccessTokenAndMakePurgeCall(GetPurgeInfo());
            MessageBox.Show(result ? @"Purge Successfull!" : @"Purge Failed! Please check the file format!");
        }
    }
}
