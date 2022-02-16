using System;
using name_sorter;
using Xunit;


namespace NameSorterUnitTests
{
    public class NameSorterUTest
    {
        [Fact]
        public void TestToCheckTheSortedFile()
        {
            //arrange 
            string outputFileName = (@"C:\Users\shali\source\repos\name-sorter\bin\Debug\netcoreapp3.1\sorted-names-list.txt");
            string[] expectedName = System.IO.File.ReadAllLines(outputFileName);

            //act
            string[] actualName = Program.SortedList(@"C:\Users\shali\source\repos\name-sorter\bin\Debug\netcoreapp3.1\unsorted-names-list.txt");

            //assert
            Assert.Equal(expectedName, actualName);
        }
        
        [Fact]
        public void TestToCheckTrue()
        {
            Assert.True(true);
        }

    }

}
