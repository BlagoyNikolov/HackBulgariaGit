using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGameLibrary {
    public class LottoResult<T, U> {

        public LottoResult() {
            IsWinning = false;
            MatchedNumbersCount = 0;
        }

        public bool IsWinning { get; set; }
        public byte MatchedNumbersCount { get; set; }

        public LottoResult(Combination<T, U> userCombination, Combination<T, U> winningCombination) {
            MatchedNumbersCount = 0;
            for (int i = 0; i < 6; i++) {
                if (userCombination.FirstT.Equals(winningCombination.FirstT)) {
                    MatchedNumbersCount++;
                }
                else if (userCombination.SecondT.Equals(winningCombination.SecondT)) {
                    MatchedNumbersCount++;
                }
                else if (userCombination.ThirdT.Equals(winningCombination.ThirdT)) {
                    MatchedNumbersCount++;
                }
                else if (userCombination.FirstU.Equals(winningCombination.FirstU)) {
                    MatchedNumbersCount++;
                }
                else if (userCombination.SecondU.Equals(winningCombination.SecondU)) {
                    MatchedNumbersCount++;
                }
                else if (userCombination.ThirdU.Equals(winningCombination.ThirdU)) {
                    MatchedNumbersCount++;
                }
            }
            if (MatchedNumbersCount > 1) {
                IsWinning = true;
            }
        }
    }
}
