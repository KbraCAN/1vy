using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HW1VY_14253017
{
    class StackWithPalindrome
    {
        static Regex whitespace = new Regex(@"\s+", RegexOptions.Compiled);
        public static string TrimAllWithRegex(string str)
        {
            return whitespace.Replace(str, "");
        }

        public void palindromeOrNot_T()
        {
            string kelime;
            Stack<char> stack = new Stack<char>();
            Stack<char> stackReverse = new Stack<char>();
            Stack<char> stackCopy = new Stack<char>();
            Console.WriteLine("Kelime Gir !!!!!!!!");
            kelime = Console.ReadLine();
            kelime = TrimAllWithRegex(kelime);
            kelime = Regex.Replace(kelime, @"[^\w\s]", ""); //Noktalama işaretleri için regex stackoverFlow
            char[] kelimeDizisi = kelime.ToCharArray();     //aldığımız kelimeyi harf harf ayırdı

            for (int i = 0; i < kelimeDizisi.Length; i++)
            {
                stack.Push(kelimeDizisi[i]);
                stackCopy.Push(kelimeDizisi[i]);
            }
            while (stackCopy.Count != 0)
            {
                stackReverse.Push(stackCopy.Pop());                  //reverse ile tersten aldı.
            }
            bool flag = true;
            while (stack.Count != 0)
            {
                if (Char.ToLower(stack.Peek()) == Char.ToLower(stackReverse.Peek()))
                {
                    stack.Pop();
                    stackReverse.Pop();
                }
                else
                {
                    Console.WriteLine("Palindrom Değildir");
                    flag = false;
                    break;
                }
            }
            if (flag == true)
                Console.WriteLine("Palindromdur.");
        }
    }
}







    

