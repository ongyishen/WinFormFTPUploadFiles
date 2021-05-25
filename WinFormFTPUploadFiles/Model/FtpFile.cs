namespace WinFormFTPUploadFiles
{
    public class FtpFile
    {
        public bool IsUpload { get; set; }

        public string Name { get; set; }

        public double Size { get; set; }

        public string FileFullPath { get; set; }


        public FtpFile()
        {
            IsUpload = false;
        }
    }
}
