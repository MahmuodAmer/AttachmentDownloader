namespace AttachmentDownloader
{
    public class Options
    {
        public string host { get; set; } = "";
        public string username { get; set; } = "";
        public string password { get; set; } = "";
        //If you wish to search through all messages
        //regardless of folder, omit the --imap-folder argument.
        public string IMapFolder { get; set; } = "";
        public string SubjectRegex { get; set; } = "";
        public string DateAfter { get; set; } = "";
        public string DateBefore { get; set; } = "";
        public string FileNameTemplate { get; set; } = "";
        public string Output { get; set; } = "";
        public string Delete { get; set; } = "";
        public string DeleteCopyFolder { get; set; } = "";
        public string Port { get; set; } = "";
        public string Unsecure { get; set; } = "";
        public string starttls { get; set; } = "";
        public string PythonPath { get; set; } = "";
    }
}
