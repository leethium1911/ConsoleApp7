using System;

namespace ConsoleApp7
{
    class Program
    {
        static char[] zet = new char[30];
        static int z = 0;
        static void Main(string[] args)
        {
            for (int j = 0; j < zet.Length; j++)
            {
                char s = Convert.ToChar(Console.ReadLine());
                AddChar(s);
            }

        }

        static void AddChar(char s)
        {

            int check = 0;
            for (int j = 0; j < zet.Length; j++)
            {
                if (zet[j] == s && check == 0)
                {

                    Console.WriteLine("Введенная буква уже присутствует в массиве");
                    check++;
                }
            }
            if (check == 0)
            {

                Console.WriteLine("Введенной буквы еще нет в массиве");
                zet[z] = s;
                Console.WriteLine("Буква была добавлена в массив");
            }

            z++;

        }

        static bool CheckChar(char s)
        {
            bool v = true;
            int check = 0;
            for (int j = 0; j < zet.Length; j++)
            {
                if (zet[j] == s && check == 0)
                {
                    v = true;
                    check++;
                }
            }
            if (check == 0)
            {
                v = false;
            }
            return v;
        }


    }
}