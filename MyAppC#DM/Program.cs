// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

    using System;  
      
    namespace DateTimeFormatInCSharpSample  
    {  
        class Program  
        {  
            static void Main(string[] args)  
            {  
                
                DateTime aDate = DateTime.Now;  
                
                Console.WriteLine(aDate.ToString("dddd MMMM"));  
      
                Console.ReadKey();  
            }  
        }  
    }  
