using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallengemar4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question1();
        }
        public static void Question1()
        {
            string alpha = "password";
            string upper = "";
            string lower = "";
            int num;
            int count = 0;
            if(alpha.Length>=6 && alpha.Length <= 20)
            {
                count += 2 ;
            }
            for(int i = 0; i < alpha.Length;i++)
            {
                upper=alpha[i].ToString().ToUpper();
                if (alpha.Contains(alpha[i]))
                {
                    count++;
                }
                lower = alpha[i].ToString().ToLower();
                if (alpha.Contains(alpha[i]))
                {
                    count++;
                }
                num = alpha[i];
                if (alpha.Contains(alpha[i]))
                {
                    count++;
                }


            }
            Console.WriteLine(count);
        }
        public static void Question2()
        {
            string[] alpha = { "a", "ab", "abc", "d", "cd", "byz", "abcd","hsdghh" };
            int maxcount = 0;
            string concat = "";
            string firstalpha = "";
            string secondalpha = "";
            string m = "";
            for(int i = 0; i < alpha.Length-1; i++)
            {
                for(int j = 0; j < alpha.Length-1; j++)
                {
                    if(alpha[i].Length == alpha[j].Length && i!=j)
                    {
                        concat = $"{alpha[i]}{alpha[j]}";
                        if (alpha[i].Length > maxcount)
                        {
                            maxcount = alpha[i].Length;
                            foreach (var item in concat.Distinct())
                            {
                                m += item;
                            }
                        }
                        if (m.Length != concat.Length)
                        {
                            break;
                        }
                        else
                        {
                            firstalpha = alpha[i];
                            secondalpha = alpha[j];
                        }
                    }
                    m = "";
                }
            }
            Console.WriteLine(firstalpha.Length*secondalpha.Length);
            
        }
        public static void Question3()
        {
            string text = "the day is sunny the the the sunny is is";
            var sign = text.Split(' ');
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var item in sign)
            {
                if (item != "")
                {
                    string s = item;
                    if (words.ContainsKey(s))
                    {
                        words[s] = words[s] + 1;
                    }
                    else
                    {
                        words.Add(s, 1);
                    }
                }

            }
            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
        }
    }
}
