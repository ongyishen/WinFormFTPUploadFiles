namespace WinFormFTPUploadFiles
{
    public class WinConfig
    {
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }
        public string FilePath { get; set; }

        public WinConfig()
        {
            Host = "localhost";
            Username = "user";
            Password = "password";
            Port = "21";
            FilePath = "";
        }
    }
}
