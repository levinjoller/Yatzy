using Xunit;

namespace Yatzy.Test
{
    public class YatzyTest
    {
        [Fact]
        public void GetSumOfAllScores_SumOfAllScores()
        {
            Yatzy instance = new Yatzy(2, 3, 4, 5, 1);
            int actual = instance.GetSumOfAllScores();
            Assert.Equal(15, actual);
        }

        [Fact]
        public void GetOnes_SumOfAllOnes()
        {
            Yatzy instance = new Yatzy(1, 2, 1, 4, 5);
            int actual = instance.GetOnes();
            Assert.Equal(2, actual);
        }

        [Fact]
        public void GetTwos_SumOfAllTwos()
        {
            Yatzy instance = new Yatzy(1, 2, 3, 2, 6);
            int actual = instance.GetTwos();
            Assert.Equal(4, actual);
        }

        [Fact]
        public void GetTwos_AllScoresAreTwos_SumOfAllTwos()
        {
            Yatzy instance = new Yatzy(2, 2, 2, 2, 2);
            int actual = instance.GetTwos();
            Assert.Equal(10, actual);
        }

        [Fact]
        public void GetThrees_SumOfAllThrees()
        {
            Yatzy instance = new Yatzy(1, 2, 3, 2, 3);
            int actual = instance.GetThrees();
            Assert.Equal(6, actual);
        }

        [Fact]
        public void GetFours_SumOfAllFours()
        {
            Yatzy instance = new Yatzy(4, 4, 4, 5, 5);
            int actual = instance.GetFours();
            Assert.Equal(12, actual);
        }

        [Fact]
        public void GetFives_SumOfAllFives()
        {
            Yatzy instance = new Yatzy(4, 4, 5, 5, 5);
            int actual = instance.GetFives();
            Assert.Equal(15, actual);
        }

        [Fact]
        public void GetSixes_SumOfAllSixes()
        {
            Yatzy instance = new Yatzy(6, 5, 6, 6, 5);
            int actual = instance.GetSixes();
            Assert.Equal(18, actual);
        }

        [Fact]
        public void GetOnePair_SumOfLargestScorePair()
        {
            Yatzy instance = new Yatzy(5, 3, 6, 6, 5);
            int actual = instance.GetOnePair();
            Assert.Equal(12, actual);
        }

        [Fact]
        public void GetOnePair_NoPair_Zero()
        {
            Yatzy instance = new Yatzy(1, 2, 3, 4, 5);
            int actual = instance.GetOnePair();
            Assert.Equal(0, actual);
        }

        [Fact]
        public void GetThreeOfAKind_SumOfThreeEqualScores()
        {
            Yatzy instance = new Yatzy(5, 3, 5, 4, 5);
            int actual = instance.GetThreeOfAKind();
            Assert.Equal(15, actual);
        }

        [Fact]
        public void GetFourOfAKind_SumOfFourEqualScores()
        {
            Yatzy instance = new Yatzy(5, 5, 5, 4, 5);
            int actual = instance.GetFourOfAKind();
            Assert.Equal(20, actual);
        }

        [Fact]
        public void GetThreeOfAKind_ActuallyFour_SumOfThreeEqualScores()
        {
            Yatzy instance = new Yatzy(5, 3, 5, 5, 5);
            int actual = instance.GetThreeOfAKind();
            Assert.Equal(15, actual);
        }

        [Fact]
        public void GetTwoPairs_SumOfTwoScorePairs()
        {
            Yatzy instance = new Yatzy(6, 6, 1, 4, 1);
            int actual = instance.GetTwoPairs();
            Assert.Equal(14, actual);
        }

        [Fact]
        public void GetTwoPairs_TwoPairsAndThreeOfAKind_SumOfTwoScorePairs()
        {
            Yatzy instance = new Yatzy(6, 6, 1, 1, 1);
            int actual = instance.GetTwoPairs();
            Assert.Equal(14, actual);
        }

        [Fact]
        public void GetTwoPairs_TwoIdenticalPairs_Zero()
        {
            Yatzy instance = new Yatzy(3, 3, 3, 4, 3);
            int actual = instance.GetTwoPairs();
            Assert.Equal(0, actual);
        }

        [Fact]
        public void GetTwoPairs_NoPairs_Zero()
        {
            Yatzy instance = new Yatzy(5, 4, 3, 2, 1);
            int actual = instance.GetTwoPairs();
            Assert.Equal(0, actual);
        }

        [Fact]
        public void GetSmallStraight_SumOfFiveScoresInARow()
        {
            Yatzy instance = new Yatzy(2, 3, 4, 5, 1);
            int actual = instance.GetSmallStraight();
            Assert.Equal(15, actual);
        }

        [Fact]
        public void GetSmallStraight_NoStraight_Zero()
        {
            Yatzy instance = new Yatzy(2, 3, 1, 5, 1);
            int actual = instance.GetSmallStraight();
            Assert.Equal(0, actual);
        }

        [Fact]
        public void GetLargeStraight_SumOfFiveScoresInARow()
        {
            Yatzy instance = new Yatzy(2, 3, 4, 5, 6);
            int actual = instance.GetLargeStraight();
            Assert.Equal(20, actual);
        }

        [Fact]
        public void GetFullHouse_SumOfTwoAndThreeOfAKind()
        {
            Yatzy instance = new Yatzy(6, 2, 2, 2, 6);
            int actual = instance.GetFullHouse();
            Assert.Equal(18, actual);
        }

        [Fact]
        public void GetFullHouse_AllScoresAreTheSame_Zero()
        {
            Yatzy instance = new Yatzy(2, 2, 2, 2, 2);
            int actual = instance.GetFullHouse();
            Assert.Equal(0, actual);
        }

        [Fact]
        public void GetFullHouse_OnlyThreeOfAKind_Zero()
        {
            Yatzy instance = new Yatzy(2, 2, 2, 3, 4);
            int actual = instance.GetFullHouse();
            Assert.Equal(0, actual);
        }

        [Fact]
        public void GetFullHouse_NoFullHouse_Zero()
        {
            Yatzy instance = new Yatzy(6, 5, 1, 3, 4);
            int actual = instance.GetFullHouse();
            Assert.Equal(0, actual);
        }

        [Fact]
        public void GetYatzy_Return50()
        { 
            Yatzy instance = new Yatzy(6, 6, 6, 6, 6);
            int actual = instance.GetYatzy();
            Assert.Equal(50, actual);
        }
        
        [Fact]
        public void GetYatzy_OnlyFourOfAKind_Zero()
        { 
            Yatzy instance = new Yatzy(4, 1, 4, 4, 4);
            int actual = instance.GetYatzy();
            Assert.Equal(0, actual);
        }
    }
}
