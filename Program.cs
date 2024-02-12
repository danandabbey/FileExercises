using System;

namespace FileExercises
{
    public class Program
    {
        public static void Main()
        {
            
        }
        
        //Write a program that reads a text file and displays the number of words.
        public static void Exercise1()
        {
            var path = @"**path to this projects folder** /NewFile.txt";
            
            if (!File.Exists(path))
            {
                Console.WriteLine("Error File Not Found");
                
            }
            else
            {
                var content = File.ReadAllText(path);
                var list = content.Split(' ');
                Console.WriteLine($"That file contains {list.Length} words.");
            }
        }
        
        //Write a program that reads a text file and displays the longest word in the file.
        public static void Exercise2()   //not done
        {
            
            var path = @"**path to this projects folder** /NewFile.txt";
            
            if (!File.Exists(path))
            {
                Console.WriteLine("Error File Not Found");
                return;
            }
            else
            {
                var content = File.ReadAllText(path);
                var list = content.Split(' ');
                var largest = "";
                var largestLength = 0;

                foreach (var word in list)
                {
                    var length = word.Length;
                    if (length > largestLength)
                    {
                        largest = word;
                        largestLength = length;
                    }
                }

                Console.WriteLine($"The largest word in the file is '{largest}'");



            }       
        }           
    }
}