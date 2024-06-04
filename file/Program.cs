// See https://aka.ms/new-console-template for more information
using file;
using System.Text;


string path = @"D:\Helper\author.txt";

FileHandling handler = new();
//Console.WriteLine("Writing to the file");
//handler.WriteUsingFileStream(path);
//handler.WriteUsingAppenAllText(path);
//handler.WriteUsingStreamWriter(path);

Console.WriteLine("Reading From the file");
handler.ReadUsingStreamReader(path);
handler.ReadUsingFileStream(path);

Console.WriteLine("deleting the file");
handler.DeleteFileUsingFile(path);
handler.DeleteFileUsingFileInfo(path);
