using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace file
{
    public class FileHandling
    {
        public void WriteUsingAppenAllText(string path)
        {
            Console.WriteLine("Enter author name");
            var author = Console.ReadLine();
            StringBuilder sb = new();
            sb.Append(author).AppendLine(" My Foot ");
            File.AppendAllText(path, sb.ToString());
        }

        public void WriteUsingFileStream(string path)
        {
            using (FileStream fileStream = new(path, FileMode.Append, FileAccess.Write))
            {
                Console.WriteLine("Enter author name");
                var author = Console.ReadLine();
                byte[] bytes = Encoding.UTF8.GetBytes(author + Environment.NewLine);
                fileStream.Write(bytes, 0, bytes.Length);
            }

        }

        public void WriteUsingStreamWriter(string path)
        {
            Console.WriteLine("Enter author name");
            var author = Console.ReadLine();
            using (StreamWriter sw = new(path, true))
            {
                sw.WriteLine(author);
            }


        }
        public void ReadUsingStreamReader(string path)
        {
            using (StreamReader sr = new(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            };

        }


        public void ReadUsingFileStream(string path)
        {
            using (FileStream fs = new(path, FileMode.Open, FileAccess.Read))
            {

                Byte[] bytesBuffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = fs.Read(bytesBuffer, 0, bytesBuffer.Length)) > 0)
                {
                    string text = Encoding.UTF8.GetString(bytesBuffer);
                    Console.WriteLine(text);
                }
            };

        }

        public void DeleteFileUsingFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File Deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }

        public void DeleteFileUsingFileInfo(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
                Console.WriteLine("File Deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }

        }
    }
}
