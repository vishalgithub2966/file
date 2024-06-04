// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

string path = @"D:\Helper\author.txt";
FileInfo fileInfo = new FileInfo(path);
Console.WriteLine("Enter Author Id");
var authorId = Console.ReadLine();
Console.WriteLine("Enter Author Name");
var authorName = Console.ReadLine();
using (FileStream fileStream = fileInfo.Open(FileMode.Append, FileAccess.Write))
{
    
    byte[] bytes = Encoding.UTF8.GetBytes(authorId + authorName + Environment.NewLine);

    fileStream.Write(bytes, 0, bytes.Length);
}

StringBuilder sb = new StringBuilder();
sb.Append(authorId).Append("  ").Append(authorName).AppendLine("     xsddw ");
string x = sb.ToString();
File.AppendAllText(path, x);
string y = File.ReadAllText(path);
Console.WriteLine(y);




Type t = typeof(float); ;
Console.WriteLine(t.Module);
Console.WriteLine(t.BaseType);
Console.WriteLine(t.Namespace);