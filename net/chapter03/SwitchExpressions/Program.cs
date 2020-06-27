using System;
using System.IO;
using static System.Console;

namespace SwitchExpressions {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\users\hugov\code\chapter03";
            Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);
            string message = string.Empty;
            
            message = s switch{  FileStream writeableFile when s.CanWrite     => "The stream is a file that I can write to.",  FileStream readOnlyFile                      => "The stream is a read-only file.",  MemoryStream ms    => "The stream is a memory address.",null    => "The stream is null.", _ => "The stream is some other type."};WriteLine(message);

        }
    }
}
