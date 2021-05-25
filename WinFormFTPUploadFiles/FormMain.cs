using CoreFtp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormFTPUploadFiles
{
    public partial class FormMain : Form
    {
        public const string CONFIGFILENAME = "MyConfig.json";

        public FormMain()
        {
            InitializeComponent();
        }

        CoreFtp.FtpClient ftpClient { get; set; }
        WinConfig myConfig { get; set; }
        private List<FtpFile> UploadFileList { get; set; }
        #region Config
        public void BindingConfig(bool isSave)
        {
            try
            {

                if (isSave)
                {
                    myConfig.Host = Host.Text;
                    myConfig.Username = Username.Text;
                    myConfig.Password = Password.Text;
                    myConfig.Port = Port.Text;
                    myConfig.FilePath = FilePath.Text;

                }
                else
                {
                    Host.Text = myConfig.Host;
                    Username.Text = myConfig.Username;
                    Password.Text = myConfig.Password;
                    Port.Text = myConfig.Port;
                    FilePath.Text = myConfig.FilePath;
                }



            }
            catch (Exception ex)
            {

                ex.AlertError();
            }

        }

        public void LoadConfig()
        {
            try
            {
                var jsonString = CONFIGFILENAME.ReadAllLine();
                if (jsonString.IsNotEmpty())
                {
                    myConfig = jsonString.ToObject<WinConfig>();
                    if (myConfig == null)
                    {
                        myConfig = new WinConfig();
                    }
                }
                else
                {
                    myConfig = new WinConfig();
                }

                BindingConfig(false);
            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
        }

        public void SaveConfig()
        {
            try
            {
                BindingConfig(true);

                var jsonString = myConfig.ToJson();

                CONFIGFILENAME.SaveJson(jsonString);
            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
        }
        #endregion

        public void LoadFiles()
        {
            this.btnLoadFiles.DisableBtn();
            btnUpload.DisableBtn();
            try
            {
                SaveConfig();

                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(myConfig.FilePath);

                IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

                UploadFileList = new List<FtpFile>();

                foreach (var file in fileList)
                {
                    var entity = new FtpFile()
                    {

                        IsUpload = false,
                        Name = file.Name,
                        Size = file.Length.ConvertBytesToMegabytes(),
                        FileFullPath = file.FullName
                    };

                    UploadFileList.Add(entity);
                }

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = UploadFileList;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                if (UploadFileList.Any())
                {
                    btnUpload.EnableBtn();
                }




            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
            btnLoadFiles.EnableBtn();
        }

        public void UploadFiles()
        {
            btnLoadFiles.DisableBtn();
            btnUpload.DisableBtn();

            try
            {
                SaveConfig();

                int iCount = 1;
                var selectedList = this.UploadFileList.Where(x => x.IsUpload).ToList();
                progressBar1.Value = 0;
                progressBar1.Maximum = selectedList.Count;
                Application.DoEvents();
                int iTotal = selectedList.Count;



                if (iTotal > 0)
                {
                    foreach (var file in selectedList)
                    {
                        lblStatus.Text = $"{iCount++} / {iTotal}";
                        Application.DoEvents();

                        var fileinfo = new FileInfo(file.FileFullPath);

                        AsyncUtil.RunSync(() => UploadFile(fileinfo));

                        progressBar1.Increment(1);
                        Application.DoEvents();
                    }


                    "Done".AlertInfo();
                }
                else
                {
                    "Nothing to upload".AlertError();
                }


            }
            catch (Exception ex)
            {

                ex.AlertError();
            }

            btnLoadFiles.EnableBtn();
            btnUpload.EnableBtn();
        }

        public async Task UploadFile(FileInfo fileinfo)
        {
            using (var ftpClient = new FtpClient(new FtpClientConfiguration
            {
                Host = myConfig.Host,
                Username = myConfig.Username,
                Password = myConfig.Password,
                Port = myConfig.Port.ParseToInt(),
                IgnoreCertificateErrors = true
            }))
            {
                await ftpClient.LoginAsync();

                using (var writeStream = await ftpClient.OpenFileWriteStreamAsync(fileinfo.Name))
                {
                    var fileReadStream = fileinfo.OpenRead();
                    await fileReadStream.CopyToAsync(writeStream);
                }


            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.FilePath.BrowseFolder(this);
        }

        private async void btnLoadFiles_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {

                SafeInvokeExt.InvokeMethod(this, this, "LoadFiles");
            });

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FilePath.OpenFolder();
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            SaveConfig();
            "Done".AlertInfo();
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {

            await Task.Run(() =>
            {

                SafeInvokeExt.InvokeMethod(this, this, "UploadFiles");
            });

        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.UploadFileList != null)
            {
                foreach (var item in UploadFileList)
                {
                    item.IsUpload = chkSelectAll.Checked;
                }
            }

            dataGridView1.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();
            btnUpload.DisableBtn();
        }
    }
}
