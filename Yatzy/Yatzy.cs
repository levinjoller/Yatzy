using System.Collections.Generic;
using System.Linq;

namespace Yatzy
{
    public class Yatzy
    {
        private readonly List<int> scores;

        public Yatzy(int d1, int d2, int d3, int d4, int d5)
        {
            scores = new List<int>() { d1, d2, d3, d4, d5 };
        }

        public int GetSumOfAllScores()
        {
            return scores.Sum();
        }

        public int GetYatzy()
        {
            return GetSumOfScoresWithCertainOccurrence(5, true) == 0 ? 0 : 50;
        }

        private bool IsStraight(bool isLarge)
        {
            int startIndex = isLarge ? 1 : 0;
            int[] occurrences = GetOccurrencesOfAllScores();

            for (int i = startIndex; i < (startIndex + 4); i++)
            {
                if (occurrences[i] != 1)
                {
                    return false;
                }
            }
            return true;
        }

        public int GetSmallStraight()
        {
            return IsStraight(false) ? 15 : 0;
        }

        public int GetLargeStraight()
        {
            return IsStraight(true) ? 20 : 0;
        }

        public int GetFullHouse()
        {
            int twoOfAKind = GetSumOfScoresWithCertainOccurrence(2, true);
            int threeOfAKind = GetSumOfScoresWithCertainOccurrence(3, true);

            if (twoOfAKind == 0 || threeOfAKind == 0)
            {
                return 0;
            }
            else
            {
                return twoOfAKind + threeOfAKind;
            }
        }

        private int GetSumOfSameScores(int scoreToSum)
        {
            return scores.Where(number => number == scoreToSum).Sum();
        }

        public int GetOnes()
        {
            return GetSumOfSameScores(1);
        }

        public int GetTwos()
        {
            return GetSumOfSameScores(2);
        }

        public int GetThrees()
        {
            return GetSumOfSameScores(3);
        }

        public int GetFours()
        {
            return GetSumOfSameScores(4);
        }

        public int GetFives()
        {
            return GetSumOfSameScores(5);
        }

        public int GetSixes()
        {
            return GetSumOfSameScores(6);
        }

        private int GetSumOfScoresWithCertainOccurrence(int expectedQuantity, bool isExact)
        {
            int[] occurrences = GetOccurrencesOfAllScores();

            for (int i = 5; i >= 0; i--)
            {
                if (isExact ? occurrences[i] == expectedQuantity : occurrences[i] >= expectedQuantity)
                {
                    return (i + 1) * expectedQuantity;
                }
            }
            return 0;
        }

        private int[] GetOccurrencesOfAllScores()
        {
            int[] occurrences = new int[6];

            for (int i = 0; i < 5; i++)
            {
                occurrences[scores.ElementAt(i) - 1]++;
            }
            return occurrences;
        }

        public int GetOnePair()
        {
            return GetSumOfScoresWithCertainOccurrence(2, false);
        }

        public int GetThreeOfAKind()
        {
            return GetSumOfScoresWithCertainOccurrence(3, false);
        }

        public int GetFourOfAKind()
        {
            return GetSumOfScoresWithCertainOccurrence(4, false);
        }

        public int GetTwoPairs()
        {
            int[] occurrences = GetOccurrencesOfAllScores();
            int numberOfPairs = 0;
            int score = 0;
            for (int i = 5; i >= 0; i--)
            {
                if (occurrences[i] >= 2)
                {
                    numberOfPairs++;
                    score += (i + 1) * 2;
                }
            }
            return numberOfPairs == 2 ? score : 0;
        }
    }
}
