namespace AttachmentDownloader
{
    public class ArgsBuilder
    {
        private readonly Options options;
        List<string> args;

        public ArgsBuilder()
        {
            args = new List<string>();
        }

        public string CreateFromOptions(Options options)
        {
            //Add The Must appended parts{scriptname,host, username,password,outputFOlder}
            args.Clear();
            var script = "\"attachment-downloader-master\\bin\\attachment-downloader\"";
            args.Add(script);
            //args.Add("attachment-downloader");
            args.Add($"--host {options.host}");
            args.Add($"--username {options.username}");
            args.Add($"--password {options.password}");
            args.Add($"--output \"{options.Output}\"");

            //CHeck for optional args

            if (options.IMapFolder.Trim() != "")
                args.Add($"--imap-folder \"{options.IMapFolder}\"");


            if (options.SubjectRegex.Trim() != "")
                args.Add($"--subject-regex \"{options.SubjectRegex}\"");

            if (options.DateAfter.Trim() != options.DateBefore.Trim())
            {
                if (options.DateAfter.Trim() != "")
                    args.Add($"--date-after '{options.DateAfter}'");

                if (options.DateBefore.Trim() != "")
                    args.Add($"--date-before '{options.DateBefore}'");

            }

            if (options.FileNameTemplate.Trim() != "")
                args.Add($"--filename-template \"{options.FileNameTemplate}\"");

            //if (options.Delete.Trim() != "")
            //    args.Add($"--delete '{options.Delete}'");


            //if (options.DeleteCopyFolder.Trim() != "")
            //    args.Add($"--delete-copy-folder '{options.DeleteCopyFolder}'");

            if (options.Port.Trim() != "")
                args.Add($"--port {options.Port}");

            string master = "";
            foreach (var arg in args)
            {
                master += " " + arg + " ";
            }

            return master;
        }

    }
}
