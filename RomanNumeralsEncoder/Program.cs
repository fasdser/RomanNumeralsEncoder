using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsEncoder
{
    internal class Program
    {

        // Создайте функцию, принимающую положительное целое число в качестве параметра и возвращающую строку, содержащую римское числовое представление этого целого числа.
        // Современные римские цифры записываются, выражая каждую цифру отдельно, начиная с самой левой цифры и пропуская любую цифру со значением нуля.
        // Римскими цифрами 1990 год отображается: 1000=М, 900=СМ, 90=ХС; в результате MCMXC. 2008 записывается как 2000=MM, 8=VIII; или ММВIII.
        // 1666 использует каждый римский символ в порядке убывания: MDCLXVI.
        // Пример:

        // Create a function that takes a positive integer as a parameter and returns a string containing the Roman numeric representation of that integer.
        // Modern Roman numerals are written by expressing each digit separately, starting with the leftmost digit and skipping any digit with a value of zero.
        // In roman numerals 1990 is displayed: 1000=M, 900=CM, 90=XR; as a result of MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII.
        // 1666 uses each roman character in descending order: MDCLXVI.

        //          RomanConvert.Solution(1000) -- should return "M"
        //          Помощь:

        //          Symbol Value
        //          I          1
        //          V          5
        //          X          10
        //          L          50
        //          C          100
        //          D          500
        //          M          1,000
        static void Main(string[] args)
        {
            Console.WriteLine(RomanConvert.Solution(2008));
            Console.ReadLine();
        }

        public class RomanConvert
        {
            public static string Solution(int n)
            {
                string roman = "";
                string[] thousand = { "", "M", "MM", "MMM" };
                string[] hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
                string[] one = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

                roman += thousand[(n / 1000) % 10];
                roman += hundred[(n / 100) % 10];
                roman += ten[(n / 10) % 10];
                roman += one[n % 10];

                return roman;

            }
        }
        //public static string Solution(int n)
        //{
        //    if ((n < 0) || (n > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
        //    if (n < 1) return string.Empty;
        //    if (n >= 1000) return "M" + Solution(n - 1000);
        //    if (n >= 900) return "CM" + Solution(n - 900);
        //    if (n >= 500) return "D" + Solution(n - 500);
        //    if (n >= 400) return "CD" + Solution(n - 400);
        //    if (n >= 100) return "C" + Solution(n - 100);
        //    if (n >= 90) return "XC" + Solution(n - 90);
        //    if (n >= 50) return "L" + Solution(n - 50);
        //    if (n >= 40) return "XL" + Solution(n - 40);
        //    if (n >= 10) return "X" + Solution(n - 10);
        //    if (n >= 9) return "IX" + Solution(n - 9);
        //    if (n >= 5) return "V" + Solution(n - 5);
        //    if (n >= 4) return "IV" + Solution(n - 4);
        //    if (n >= 1) return "I" + Solution(n - 1);
        //    throw new ArgumentOutOfRangeException("something bad happened");
        //}
        //    public static string Solution(int n)
        //    {
        //        //double number = n;
        //        //decimal[] value = new decimal[7];
        //        //string[] symbol = new string[7];

        //        //value[0] = 1;           symbol[0] = "I";
        //        //value[1] = 5;           symbol[1] = "V";
        //        //value[2] = 10;          symbol[2] = "X";
        //        //value[3] = 50;          symbol[3] = "L";
        //        //value[4] = 100;         symbol[4] = "C";
        //        //value[5] = 500;         symbol[5] = "D";
        //        //value[6] = 1.000M;      symbol[6] = "M";

        //        //if (number % 1000 <= 10)
        //        //{
        //        //    double t = (number / 1000);
        //        //    t = Math.Floor(t);
        //        //}
        //        //else return null;

        //        //if (number/500<=10)
        //        //{
        //        //    double d =(number/500);
        //        //    d = Math.Floor(d);
        //        //} 


        //        if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
        //        if (number < 1) return string.Empty;
        //        if (number >= 1000) return "M" + Solution(number - 1000);
        //        if (number >= 900) return "CM" + Solution(number - 900);
        //        if (number >= 500) return "D" + Solution(number - 500);
        //        if (number >= 400) return "CD" + Solution(number - 400);
        //        if (number >= 100) return "C" + Solution(number - 100);
        //        if (number >= 90) return "XC" + Solution(number - 90);
        //        if (number >= 50) return "L" + Solution(number - 50);
        //        if (number >= 40) return "XL" + Solution(number - 40);
        //        if (number >= 10) return "X" + Solution(number - 10);
        //        if (number >= 9) return "IX" + Solution(number - 9);
        //        if (number >= 5) return "V" + Solution(number - 5);
        //        if (number >= 4) return "IV" + Solution(number - 4);
        //        if (number >= 1) return "I" + Solution(number - 1);
        //        throw new ArgumentOutOfRangeException("something bad happened");



        //}
    }
}
