using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "The quick brown fox jumps over the lazy dog";
            int wordCount = CountWords(inputString);//countword is a method that count--
                                                    //--number of words which is a int type

            Console.WriteLine($"Word count: {wordCount}");
            Console.ReadLine();
        }

        static int CountWords(string inputString)
        {
            string[] words = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
            //split >>> برای تقسیم یک رشته به آرایه‌ای از رشته‌های فرعی بر اساس یک جداکننده 
            // stringsplitoption.removeEmptyEntries >>>> is a method that remove empty entries (spaces) in the 
            //string and then return the length of arrey  
        }
    }
    
}
