using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGameLibrary {
    public class LottoGame<T, U> {
        private Combination<T, U> winningCombination;
        private List<Combination<T, U>> combinationContainer;

        public LottoGame(Combination<T, U> winningCombination) {
            this.winningCombination = winningCombination;
            combinationContainer = new List<Combination<T, U>>();
        }

        public bool CombinationCheck(Combination<T, U> userCombination) {
            foreach (var item in combinationContainer) {
                if (item.Equals(userCombination))
                    return true;
            }
            return false;
        }

        public void AddUserCombination(Combination<T, U> userCombination) {
            combinationContainer.Add(userCombination);
        }

        private Combination<T, U> GetWinning() {
            return winningCombination;
        }

        public LottoResult<T, U> Validate() {
            LottoResult<T, U> bestLottoResult = new LottoResult<T, U>();
            foreach (var combination in combinationContainer) {
                LottoResult<T, U> currentLottoResult = new LottoResult<T, U>(combination, GetWinning());
                if (currentLottoResult.MatchedNumbersCount > bestLottoResult.MatchedNumbersCount)
                    bestLottoResult = currentLottoResult;
            }
            return bestLottoResult;
        }
    }
}
