using System;

namespace Statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            string nums = "0123456789";
            string text = "";
            int rowNum = 0;
            do
            {
                
                key = Console.ReadKey(true);
                
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    Console.WriteLine(text);
                    text = "";
                    rowNum += 3;
                }
                else if (key.Key == ConsoleKey.Backspace && text.Length > 0)
                {
                    Console.SetCursorPosition(0, rowNum);
                    Console.Write(new string(' ', text.Length));
                    text = text.Substring(0,text.Length - 1);
                    
                    Console.SetCursorPosition(0, rowNum);
                    Console.Write(text);
                
                }
                else if (key.KeyChar == '0') 
                {
                    Console.Write(key.KeyChar);
                    
                }
                else if (nums.Contains(key.KeyChar))
                {
                    text = text + key.KeyChar;
                    Console.SetCursorPosition(0, rowNum);
                    Console.Write(text);
                }
                
            } while (key.Key != ConsoleKey.Escape);




        }
    }
}
