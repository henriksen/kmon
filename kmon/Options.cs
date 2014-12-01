using System;

namespace kmon
{
    public class Options
    {
        private readonly string[] _args;
        public Options(string[] args)
        {
            _args = args;

            Parse();
        }


        private string _server = "web";
        private string _fileExtenstions = "cs,json,js";
        private string _errorMessage = "";

        public string FileExtensions { get { return _fileExtenstions; } set { _fileExtenstions = value; } }

        public string Server { get { return _server; } set { _server = value; } }

        public bool Errors { get; set; }

        public string ErrorMessage { get { return _errorMessage; } set { _errorMessage = value; } }

        private void Parse()
        {
            for (int i = 0; i < _args.Length; i++)
            {
                Console.WriteLine(_args[i].ToString());
                if (_args[i].StartsWith("--"))
                {
                    switch (_args[i].ToLower())
                    {
                        case "--ext":
                            FileExtensions = _args[i + 1];
                            break;

                        case "--server":
                            Server = _args[i + 1];
                            break;

                    }
                }
            }
        }

        public string ParsedArgs()
        {
            return string.Format("--ext {0} --exec \"{2}k {1} \"", 
                FileExtensions, 
                Server, 
                Server.ToLower() == "web" ? "cmd /c " : "");
        }
    }
}