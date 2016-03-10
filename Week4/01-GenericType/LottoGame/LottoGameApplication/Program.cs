using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LottoGameLibrary;

namespace LottoGameApplication {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("enter the numbr of combinations");
            int numberCombinations = int.Parse(Console.ReadLine());
            Console.WriteLine("you have entered " + numberCombinations);

            Combination<int, string> winningCombination = new Combination<int, string>(1, 2, 3, "pesho", "gosho", "ivan");
            LottoGame<int, string> lottoGame = new LottoGame<int, string>(winningCombination);
            int temp = 1;
            while (temp <= numberCombinations) {
                Console.Write("Combination {0}:\n", temp);
                Console.Write("1 int: ");
                int value1 = int.Parse(Console.ReadLine());
                Console.Write("2 int: ");
                int value2 = int.Parse(Console.ReadLine());
                Console.Write("3 int: ");
                int value3 = int.Parse(Console.ReadLine());
                Console.Write("4 string: ");
                string value4 = Console.ReadLine();
                Console.Write("5 string: ");
                string value5 = Console.ReadLine();
                Console.Write("6 string: ");
                string value6 = Console.ReadLine();

                Combination<int, string> tempCombination = new Combination<int, string>(value1, value2, value3, value4, value5, value6);

                if (lottoGame.CombinationCheck(tempCombination)) {
                    Console.WriteLine("the current combination has already been entered");
                    continue;
                }
                else {
                    lottoGame.AddUserCombination(tempCombination);
                }
                temp++;
            }

            LottoResult<int, string> lottoResult = lottoGame.Validate();
            if (lottoResult.IsWinning)
                Console.WriteLine("you have {0} matches", lottoResult.MatchedNumbersCount);
            else
                Console.WriteLine("you have no matches");
        }
    }
}
