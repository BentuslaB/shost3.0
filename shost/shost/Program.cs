using System;
using System.Collections.Generic;
using System.IO;

namespace shost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "///file.txt"; 
            try
            {
                
                string text = .ReadAllText(filePath);

               
                string[] words = text.ToLower().Split(new char[] { ' ', '\n', '\r', '\t', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

               
                Dictionary<string, int> wordFrequency = new Dictionary<string, int>();      
                foreach (string word in words)
                {
                    if (wordFrequency.ContainsKey(word))
                    {
                        wordFrequency[word]++;
                    }
                    else
                    {
                        wordFrequency[word] = 1;
                    }
                }
                Console.WriteLine("Частота встречаемости слов:");
                foreach (var entry in wordFrequency)
                {
                    Console.WriteLine($"Слово: '{entry.Key}' - Частота: {entry.Value}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
