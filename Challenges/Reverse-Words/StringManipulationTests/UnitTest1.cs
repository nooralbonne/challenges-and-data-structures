using Xunit;
using Reverse_Words;

namespace TestProject1
{
    public class Test1
    {
        [Fact]
        public void ReverseWords_Test1()
        {
            string input = "csharp is programming language";
            string expected = "language programming is csharp";
            string actual = StringManipulation.ReverseWords(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseWords_Test2()
        {
            string input = "Reverse the words in this sentence";
            string expected = "sentence this in words the Reverse";
            string actual = StringManipulation.ReverseWords(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseWords_Test3()
        {
            string input = "challenges and data structures";
            string expected = "structures data and challenges";
            string actual = StringManipulation.ReverseWords(input);
            Assert.Equal(expected, actual);
        }
    }
}
