using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HW1VY_14253017
{
    class QueueWithPalindrome
    {
        static Regex whitespace = new Regex(@"\s+", RegexOptions.Compiled);
        public static string TrimAllWithRegex(string str)
        {
            return whitespace.Replace(str, "");
        }
        public void palindromeOrNot_T()
        {
            string kelime;
            Queue<char> queue = new Queue<char>();
            Console.WriteLine("Kelime Gir !!!!!!!!");
            kelime = Console.ReadLine();
            kelime = TrimAllWithRegex(kelime);
            kelime = Regex.Replace(kelime, @"[^\w\s]", ""); //Noktalama işaretleri için regex stackoverFlow
            char[] kelimeDizisi = kelime.ToCharArray();
            Queue<char> queueReverse = new Queue<char>();
            for (int i = 0; i < kelimeDizisi.Length; i++)
                queue.Enqueue(kelimeDizisi[i]);
            for (int i = kelimeDizisi.Length - 1; i >= 0; i--)
                queueReverse.Enqueue(kelimeDizisi[i]);
            bool flag = true;
            while (queue.Count != 0)
            {
                if (Char.ToUpper(queue.Peek()) == Char.ToUpper(queueReverse.Peek())) //büyük harfe çevirdim
                {
                    queue.Dequeue();
                    queueReverse.Dequeue();
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








    

