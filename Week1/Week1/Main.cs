using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.LanguageConstructs;
using ConsoleApplication2.Warmups;
using ConsoleApplication2.MoreProblems;
using System.Drawing;

namespace ConsoleApplication2 {
    class MainWeek1 {
        static void Main(string[] args) {
            //Factorial
            //Factorial.ClassicFactorial(5);
            //Factorial.RecursiveFactorial(5);

            //Lucas series
            //Lucas.nthLucas(5);
            //Lucas.firstLucas(5);

            //Working with digits
            //WorkingWithDigits.CountDigits(123456);
            //WorkingWithDigits.sumDigits(1054);
            //WorkingWithDigits.factorialDigits(145);

            //Fibonacci number
            //Fibonacci.fibNumber(3);
            //Fibonacci.fibNumber(10);

            //Hack numbers
            //Console.WriteLine(HackNumbers.isHack(21));
            //Console.WriteLine(HackNumbers.nextHack(10));

            //Vowels in a string
            //Console.WriteLine(Vowels.CountVowels("Github is the second best thing that happend to programmers, after the keyboard!"));

            //Consonants in a string
            //Console.WriteLine(Consonants.CountConsonants("Github is the second best thing that happend to programmers, after the keyboard!"));

            //Char Histogram
            //CharHistogramA.CharHistogram("Python!");

            //Palindrome Score
            //Console.WriteLine(PalindromeScore.PScore(121));
            //Console.WriteLine(PalindromeScore.PScore(48));
            //Console.WriteLine(PalindromeScore.PScore(198));

            //Integer palindomes
            //Console.WriteLine(IntegerPalindomes.IsIntPalindrome(11511));
            //Console.WriteLine(IntegerPalindomes.GetLargestPalindrome(150));

            //Prime numbers
            //Console.WriteLine(PrimeNumbers.IsPrime(3));
            //PrimeNumbers.ListFirstPrimes(10);

            //Sum all numbers in a given string
            //SumNumbersInString.SumOfNumbersInString("1abc33xyz22");
            //Console.WriteLine(SumNumbersInString.SumOfNumbersInString("1abc33xyz22"));
            //Console.WriteLine(SumNumbersInString.SumOfNumbersInString("abcd"));

            //Anagrams
            //Console.WriteLine(StringAnagrams.Anagram("army", "mary"));
            //Console.WriteLine(AnagramSubsequence.HasAnagramOf("ABAB", "AAABABAA"));


            //-----------------------------------------------------------------------------
            //Number->List and List->Number
            //var elem = NumberToListAndListToNumber.NumberToList(123456789);
            //List<int> digits = new List<int>();
            //digits.Add(4);
            //digits.Add(8);
            //digits.Add(7);
            //digits.Add(3);
            //Console.Write(NumberToListAndListToNumber.ListToNumber(digits));

            //Increasing and Decreasing Sequences
            //int[] array = { 5, 4, 3, 2, 1 };
            //Console.WriteLine(IncreasingAndDecreasingSequences.IsIncreasing(array));
            //Console.WriteLine(IncreasingAndDecreasingSequences.IsDecreasing(array));

            //Extreme elements in a list
            //int[] array = { 5, 4, 3, 2, 1, 8, 9, 15, 87, 2, 9, 109, 0, -87, -200, 500, 1000 };
            //Console.WriteLine(ExtremeElementsInAList.Min(array));
            //Console.WriteLine(ExtremeElementsInAList.Max(array));
            //Console.WriteLine(ExtremeElementsInAList.NthMin(3, array));
            //Console.WriteLine(ExtremeElementsInAList.NthMax(3, array));

            //Reverse a String
            //Console.WriteLine(ReverseString.ReverseMe("HackBulgaria"));

            //Reverse each word in a sentence
            //Console.WriteLine(ReverseSentence.ReverseEveryWord("Github is the second best thing that happend to programmers, after the keyboard!"));

            //Copy every character K times
            //CopyCharacterKTtimes.CopyEveryChar("abcdefg", 5);

            //Decode an URL
            //Console.WriteLine(DecodeURL.DecodeUrl("kitten%20Apic.jpg%3Dasd"));

            //Is String A an anagram of String B?
            //Console.WriteLine(StringAnagrams.Anagram("army", "mary"));

            //Is an anagram of String A a SUBSEQUENCE in B?
            //Console.WriteLine(AnagramSubsequence.HasAnagramOf("ABAB", "AAABABAA"));

            //-----------------------------------------------------------------------------
            //Grayscale Image
            Bitmap bmp = (Bitmap)Image.FromFile("poster.bmp");
            //Grayscale.GreyScaleImage(bmp, "C:\\Users\\Blagoy\\Desktop\\grayscalePoster.bmp");

            //Interpolate image (nearest neighbour)
            //InterpolateImage.ResampleImage(bmp, new Size(1200,1600), "C:\\Users\\Blagoy\\Desktop\\interpolatedPoster.bmp");

            //Apply a linear filter to an image
            BoxFilter.BlurImage(bmp, "C:\\Users\\Blagoy\\Desktop\\bluredPoster.bmp");

            //Maximal Scalar Product
            //List<int> v1 = new List<int> { 3, 8, 2, 1, 6, 8, 7, 9, 7, 5, 7, 6, 5, 1 };
            //List<int> v2 = new List<int> {9, 12, 0, 15, 5};
            //Console.WriteLine("The sum of v1 and v2 is: " + MaximalScalarProduct.MaxScalarProduct(v1, v2));
            //v1.ForEach(Console.WriteLine);
            //v2.ForEach(Console.WriteLine);

            //Max Span
            //Console.WriteLine("The max span of the list is: " + MaxSpanOfNumbers.MaxSpan(v1));

            //Birthday Ranges
            //var birthdays = new List<int>() { 5, 10, 6, 7, 3, 4, 5, 11, 21, 300, 15 };
            //var ranges = new List<KeyValuePair<int, int>>() {new KeyValuePair<int, int>(4, 9),
            //    new KeyValuePair<int, int>(6, 7),
            //    new KeyValuePair<int, int>(200, 225),
            //    new KeyValuePair<int, int>(300, 365),
            //    new KeyValuePair<int, int>(4, 6),
            //    };
            //Birthday.BirthdayRanges(birthdays, ranges);

            //Matrix Bombing
            //int[,] array2D = new int[,] { { 10, 10, 10 }, { 10, 11, 10 }, { 10, 10, 10 } };
            //NOTDONETheMatrix.MatrixBombing(array2D, 11);

            //Transversal
        }
    }
}