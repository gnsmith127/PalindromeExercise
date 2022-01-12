using System;
using System.Linq;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] 
        [InlineData ("hello", false)]
        [InlineData ("tenet", true)]
        public void IsAPalindrome(string word, bool expected)
        {
            var test = new WordSmith();
            bool actual = test.IsAPalindrome(word);
            Assert.Equal(actual, expected);
        }
    }
}
