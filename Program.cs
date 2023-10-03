// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

 
class Program
{
    static void Main(string[] args)
    {
        Process.Start("notepad.exe");
        Console.WriteLine("Hello, World!");
      //  string text = "HelloWorld!";
       // string writePath = "C:/Users/User/Desktop/hello.txt";
        using (StreamWriter sw = new StreamWriter("C:/Users/User/Desktop/hello.txt"))
        {
            sw.WriteLine("Hello Pavel Olegovich");
        }
    }
}
