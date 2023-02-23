using System;

namespace gbhw4
{
    class Program
    {
        // 1, 2.2, 3...
        // static int ReadInt(string prompt){
        //     Console.WriteLine(prompt);
        //     return Convert.ToInt32(Console.ReadLine());
        // }

        // 1...
        // static int Power(int b, int p){
        //     int result = 1;
        //     for (int i = 0; i < p; i++)
        //     {
        //         result *= b;
        //     }
        //     return result;
        // }

        // 2.1...
        // static int ReadStr(string prompt){
        //     Console.WriteLine(prompt);
        //     return Convert.ToInt32(Console.ReadLine());
        // }

        // static int SumDigitsByString(string number){
        //     int result = 0;
        //     for (int i = 0; i < number.Length; i++)
        //     {
        //         result += Convert.ToInt32(Char.ToString(number[i]));
        //     }
        //     return result;
        // }

        // 2.2...

        // static int GetNthDigit(int number, int n){
        //     return Convert.ToInt32((number%Math.Pow(10, n+1)-number%Math.Pow(10, n))/Math.Pow(10, n));
        // }

        // static int SumDigitsByMath(int number){
        //     int result = 0;
        //     int numberlength = 0;
        //     int number2 = number;
        //     while(number2 > 0){
        //         number2 /= 10;
        //         numberlength++;
        //     }
        //     for (int i = 0; i < numberlength; i++)
        //     {
        //         result += GetNthDigit(number, i);
        //     }
        //     return result;
        // }

        // 3...
        // static int[] RandomArray(int len){
        //     int[] array = new int[len];
        //     Random rnd = new Random();
        //     for (int i = 0; i < len; i++)
        //     {
        //         array[i] = rnd.Next(1, 10);
        //     }
        //     return array;
        // }

        // static void OutputArray(int[] array){
        //     Console.Write("{");
        //     for (int i = 0; i < array.Length-1; i++)
        //     {
        //         Console.Write(array[i]+", ");
        //     }
        //     Console.WriteLine(array[array.Length-1]+"}");
        }

        static void Main(string[] args)
        {
            // 1...
            // int baza = ReadInt("Введите основание степени: ");
            // int stepen = ReadInt("Введите показатель степени: ");
            // Console.WriteLine(Power(baza, stepen));

            // 2.1...
            // Console.WriteLine(SumDigitsByString(ReadStr("Введите число: ")));

            // 2.2...
            // Console.WriteLine(SumDigitsByMath(ReadInt("Введите число: ")));

            // 3...
            // OutputArray(RandomArray(ReadInt("Введите длину массива: ")));
        }
    }
}
