using System;
using Xunit;
using Common_Elements;

namespace Common_Elements.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void TestFindCommonElements_Case1()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 1, 2, 5, 6 };
            int[] expected = { 1, 2 };

            var result = Program.FindCommonElements(array1, array2);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestFindCommonElements_Case2()
        {
            int[] array1 = { 79, 8, 15 };
            int[] array2 = { 23, 79, 8 };
            int[] expected = { 79, 8 };

            var result = Program.FindCommonElements(array1, array2);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestFindCommonElements_Case3()
        {
            int[] array1 = { 5, 10, 15, 20 };
            int[] array2 = { 10, 15, 25 };
            int[] expected = { 10, 15 };

            var result = Program.FindCommonElements(array1, array2);
            Assert.Equal(expected, result);
        }
    }
}
