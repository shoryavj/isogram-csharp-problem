using System;
using Isogram;
using Xunit;

namespace Isogram.Tests
{
    public class UnitTest
    {
        [Fact]
        public void EmptyString()
        {

            Assert.Equal(true, Program.isogram(""));
        }
        [Fact]
        public void TestIsogram()
        {

            Assert.Equal(true, Program.isogram("isogram"));
        }

        [Fact]
        public void Eleven()
        {

            Assert.Equal(false, Program.isogram("eleven"));
        }

        [Fact]
        public void LongWords()
        {

            Assert.Equal(true, Program.isogram("subdermatoglyphic"));
        }

        [Fact]
        public void UpperCase()
        {

            Assert.Equal(true, Program.isogram("Alphabet"));
        }


        [Fact]
        public void Hyphen()
        {

            Assert.Equal(true, Program.isogram("thumbscrew-japingly"));
        }

        [Fact]
        public void DuplicatedHyphen()
        {

            Assert.Equal(true, Program.isogram("six-year-old"));
        }

        [Fact]
        public void Space()
        {

            Assert.Equal(true, Program.isogram("shorya"));
        }

    }
}