using System;
using System.Linq;
using System.Text;

namespace lab1_OPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите bool: ");
            bool bool1 = false;
            bool.TryParse(Console.ReadLine(), out bool1);
            Console.WriteLine("\nbool: " + bool1 + "\n");

            Console.WriteLine("Введите byte: ");
            byte byte1;
            byte.TryParse(Console.ReadLine(), out byte1);
            Console.WriteLine("\nbyte: " + byte1 + "\n");

            Console.WriteLine("Введите sbyte: ");
            sbyte sbyte1;
            sbyte.TryParse(Console.ReadLine(), out sbyte1);
            Console.WriteLine("\nsbyte: " + sbyte1 + "\n");

            Console.WriteLine("Введите char: ");
            char char1;
            char.TryParse(Console.ReadLine(), out char1);
            Console.WriteLine("\nchar: " + char1 + "\n");

            Console.WriteLine("Введите decimal: ");
            decimal decimal1;
            decimal.TryParse(Console.ReadLine(), out decimal1);
            Console.WriteLine("\ndecimal: " + decimal1 + "\n");

            Console.WriteLine("Введите double: ");
            double double1;
            double.TryParse(Console.ReadLine(), out double1);
            Console.WriteLine("\ndouble: " + double1 + "\n");

            Console.WriteLine("Введите float: ");
            float float1;
            float.TryParse(Console.ReadLine(), out float1);
            Console.WriteLine("\nfloat: " + float1 + "\n");

            Console.WriteLine("Введите int: ");
            int int1;
            int.TryParse(Console.ReadLine(), out int1);
            Console.WriteLine("\nint: " + int1 + "\n");

            Console.WriteLine("Введите unsigned int: ");
            uint uint1;
            uint.TryParse(Console.ReadLine(), out uint1);
            Console.WriteLine("\nuint: " + uint1 + "\n");

            Console.WriteLine("Введите long: ");
            long long1;
            long.TryParse(Console.ReadLine(), out long1);
            Console.WriteLine("\nlong: " + long1 + "\n");

            Console.WriteLine("Введите unsigned long: ");
            ulong ulong1;
            ulong.TryParse(Console.ReadLine(), out ulong1);
            Console.WriteLine("\nulong: " + ulong1 + "\n");

            Console.WriteLine("Введите short: ");
            short short1;
            short.TryParse(Console.ReadLine(), out short1);
            Console.WriteLine("\nshort: " + short1 + "\n");

            Console.WriteLine("Введите unsigned short: ");
            ushort ushort1;
            ushort.TryParse(Console.ReadLine(), out ushort1);
            Console.WriteLine("\nushort: " + ushort1 + "\n");


            // Неявные преобразования
            byte b = 5;
            short s = b;
            int i = s;
            long l = b;
            double d = l;
            Console.WriteLine($"Short = {s}, Int = {i}, Long = {l}, Double = {d}");

            string str1 = "2432";
            short s1 = Convert.ToInt16(str1);
            int i1 = Convert.ToInt32(str1 + str1);
            short s2 = (short)(i1);
            double d1 = Convert.ToDouble(str1);
            Console.WriteLine($"Short 1 = {s1}, Int 1 = {i1}, short 2 = {s2}, Double 1 = {d1}");


            // Упаковка и распаковка значимых типов
            int pac_int = 123;
            object o = pac_int;
            int j = (int)o;
            Console.WriteLine("Упакованное значение: " + j);


            // Неявно типизированный тип данных
            for (var varI = 1; varI <= 5; varI++)
            {
                Console.WriteLine(varI);
            }
            var varStr = "Строчка";
            Console.WriteLine(varStr);

            var varInt = 32;
            varInt++;
            Console.WriteLine(varInt);


            // Упрощённый вариант объявления Nullable
            int? nullInt1 = null;
            Console.WriteLine(nullInt1); // Пустая строка

            nullInt1 = 5;
            Console.WriteLine(nullInt1);

            // Другой вариант объявления Nullable
            Nullable<int> nullInt2 = null;
            Console.WriteLine(nullInt2); // Пустая строка
            nullInt2 = 7;
            Console.WriteLine(nullInt2);


            /*// Ошибка присвоение var
            var someVar = 3;
            Console.WriteLine(someVar);
            someVar = "а тут уже строчка"; // Ошибка возникает по причине определения типа данных на стадии объявления переменной,
                                           // переменной уже присвоился тип данных автоматически, и поменять по ходу программы его нельзя
            Console.WriteLine(someVar);*/


            //2a
            char ch1 = 's', ch2 = 's';
            if (ch1 == ch2)
                Console.WriteLine("Литералы равны");

            //2b
            Console.WriteLine();
            string some_str1 = "first", copystr, some_str2 = "second", some_str3 = "third", some_str4 = "Тут три слова";
            Console.WriteLine($"Сцепление: {some_str1 + some_str3}");
            copystr = String.Copy(some_str2);
            Console.WriteLine($"Копия строки {copystr}");
            Console.WriteLine(some_str2.Insert(3, some_str3));
            Console.WriteLine(some_str1.Substring(4));
            string[] splitstr = some_str4.Split(' ');
            Console.WriteLine($"{splitstr[0]}, {splitstr[1]}, {splitstr[2]}");

            //2c
            Console.WriteLine();
            string nul = null, empt = "";
            Console.WriteLine("Null or Empty:");
            Console.WriteLine(string.IsNullOrEmpty(nul));
            Console.WriteLine(string.IsNullOrEmpty(empt));
            Console.WriteLine(string.IsNullOrEmpty(copystr));

            //2d
            Console.WriteLine();
            StringBuilder newstr = new StringBuilder("hi i'm Gleb");
            Console.WriteLine(newstr.Remove(2, 4));
            Console.WriteLine(newstr.Insert(2, " ++++"));

            //3a
            byte[,] matrix = { { 1, 2, 3 }, { 3, 4, 3 }, { 5, 6, 3 } };
            Console.WriteLine("Матрица: ");
            for (byte i_byte = 0; i_byte < matrix.GetLength(0); i_byte++)
            {
                for (byte j_byte = 0; j_byte < matrix.GetUpperBound(0) + 1; j_byte++)
                {
                    Console.Write($"{matrix[i_byte, j_byte]}\t");
                };
                Console.WriteLine();
            };

            //3b
            Console.WriteLine();
            string[] days = { "Mon", "Tue", "Wed", "Thi", "Fri", "Sat", "Sun" };
            Console.Write($"Длинна массива days: {days.Length}\n");
            for (byte i_byte = 0; i_byte < days.Length; i_byte++)
                Console.Write("Day[{0}] = {1}; ", i_byte, days[i_byte]);
            Console.Write("Текст: ");
            string day_value = Console.ReadLine();
            int swap_index;
            Console.Write("Индекс: ");
            int.TryParse(Console.ReadLine(), out swap_index);
            days[swap_index] = day_value;
            for (byte i_byte = 0; i_byte < days.Length; i_byte++)
                Console.Write("Day[{0}] = {1}; ", i_byte, days[i_byte]);

            int[][] nums = new int[3][];
            nums[0] = new int[2] { 1, 2 };
            nums[1] = new int[3] { 1, 2, 3 };
            nums[2] = new int[4] { 1, 2, 3, 4 };

            //3d
            var notT = new[] { 1, 2, 3, 4 };
            for (byte i_byte = 0; i_byte < notT.Length; i_byte++)
                Console.Write("Element_Index[{0}] = {1}; ", i_byte, notT[i_byte]);

            //4a
            Console.WriteLine();
            (int, string, char, string, ulong) kort = (1, "Peace", 'a', "Death", 351);

            //4b
            Console.WriteLine($"\nКортеж целиком: {kort}");
            Console.WriteLine($"Частично: {kort.Item1}, {kort.Item4}");

            //4c
            int r1; string r2, r4; char r3; ulong r5;
            (r1, r2, r3, _, _) = kort;
            Console.WriteLine(r2);

            //4d
            (int, string, char, string, ulong) kort_2 = (1, "hello", 'b', "world", 123);
            var z = (kort == kort_2) ? "Кортежи равны" : "Кортежи не равны";
            Console.WriteLine(z);

            //5
            (byte, byte, byte, char) localfunction(int[] mass, string str)
            {
                byte max = (byte)mass.Max(),
                     min = (byte)mass.Min(),
                     sum = (byte)mass.Sum();
                char firstsymb = str.First();
                return (max, min, sum, firstsymb);
            }
            int[] massive = { 1, 4, 2, 6, 7 };
            string strin = "Hello";
            Console.WriteLine("\nЛокальная функция:");
            Console.WriteLine(localfunction(massive, strin));

            //6
            int func_checked()
            {
                checked
                {
                    int q = int.MaxValue;
                    try
                    {
                        return q + 1;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("переполнение");
                        return q;
                    }
                }
            }
            int func_unchecked()
            {
                unchecked
                {
                    int q = int.MaxValue;
                    try
                    {
                        return q + 1;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("переполнение");
                        return q;
                    }
                }
            }

            Console.WriteLine(func_checked());
            Console.WriteLine(func_unchecked());

            Console.ReadKey();
        }
    }
}
