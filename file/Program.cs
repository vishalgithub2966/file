// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

string path = @"C:\Users\LNV-194\Documents\author.txt";
//FileInfo fileInfo= new FileInfo(path);
//FileStream fileStream = fileInfo.Open(FileMode.Open);
//Console.WriteLine("Enter Author Id");
//var authorId = Console.ReadLine();
//Console.WriteLine("Enter Author Name");
//var authorName = Console.ReadLine();

//StringBuilder sb=new StringBuilder();
//sb.Append(authorId).Append("  ").Append(authorName).AppendLine("     xsddw ");
//string x=sb.ToString();
//File.AppendAllText(path, x);
//string y=File.ReadAllText(path);
//Console.WriteLine(y);


//StreamWriter sw = new StreamWriter(fileStream);
//sw.Write(authorId);
//sw.Write(authorName);
//sw.Close();
//StreamReader sr = new StreamReader(fileStream);   
//string str=sr.ReadLine();
//Console.WriteLine($" {str}");
//sr.Close();

Type t = typeof(float);
Console.WriteLine(t.Module);
Console.WriteLine(t.BaseType);
Console.WriteLine(t.Namespace);