using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadSharpBusinessLogic
{
    public interface IFileManager
    {
        string GetContent(string path);
        string GetContent(string path, Encoding encoding);
        void SaveContent(string content, string path);
        void SaveContent(string content, string path, Encoding encoding);
        int Count(string content);
    }

    public class FileManager : IFileManager
    {
        private readonly Encoding defaultEncoding = Encoding.GetEncoding(1251);

        public string GetContent(string path)
        {
            return GetContent(path, defaultEncoding);
        }

        public string GetContent(string path, Encoding encoding)
        {
            return File.ReadAllText(path, encoding);
        }

        public void SaveContent(string content, string path)
        {
            SaveContent(content, path, defaultEncoding);
        }

        public void SaveContent(string content, string path, Encoding encoding)
        {
            File.WriteAllText(path, content, encoding);
        }

        public int Count(string content)
        {
            return content.Length;
        }




    }
}
