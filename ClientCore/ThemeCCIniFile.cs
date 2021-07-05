using Rampastring.Tools;
using System.IO;

namespace ClientCore
{
    public class ThemeCCIniFile : CCIniFile
    {
        private const string GENERIC_WINDOW_INI = "GenericWindow.ini";
        public ThemeCCIniFile(string path) : base(path)
        {
            if (File.Exists(ProgramConstants.GetResourcePath() + path + ".ini"))
                FileName = ProgramConstants.GetResourcePath() + path + ".ini";
            else if (File.Exists(ProgramConstants.GetBaseResourcePath() + path + ".ini"))
                FileName = ProgramConstants.GetBaseResourcePath() + path + ".ini";
            else if (File.Exists(ProgramConstants.GetResourcePath() + GENERIC_WINDOW_INI))
                FileName = ProgramConstants.GetResourcePath() + GENERIC_WINDOW_INI;
            else
                FileName = ProgramConstants.GetBaseResourcePath() + GENERIC_WINDOW_INI;

            Parse();
        }
    }
}

