using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager_Tests
{
    public class StringManipulationTests
    {
        private string testString = "1 - [ Social Media ] Instagram [ Cadu ] = Is@bnkh5$@bvj";
       
        [Fact]
        public void GetId_ShouldReturn_Id()
        {
            StringManipulation strMpl = new StringManipulation(testString);

            string stringExpected = "1";
            string stringGenerated = strMpl.GetId();

            Assert.Equal(stringExpected.Length, stringGenerated.Length);
            Assert.Equal(stringExpected, stringGenerated);
        }
        
        [Fact]
        public void GetGroup_ShouldReturn_Group()
        {
            StringManipulation strMpl = new StringManipulation(testString);

            string stringExpected = "Social Media";
            string stringGenerated = strMpl.GetGroup();

            Assert.Equal(stringExpected.Length, stringGenerated.Length);
            Assert.Equal(stringExpected, stringGenerated);
        }
        
        [Fact]
        public void GetTittle_ShouldReturn_Tittle()
        {
            StringManipulation strMpl = new StringManipulation(testString);

            string stringExpected = "Instagram";
            string stringGenerated = strMpl.GetTittle();

            Assert.Equal(stringExpected.Length, stringGenerated.Length);
            Assert.Equal(stringExpected, stringGenerated);
        }
       
        [Fact]
        public void GetUsername_ShouldReturn_Username()
        {
            StringManipulation strMpl = new StringManipulation(testString);

            string stringExpected = "Cadu";
            string stringGenerated = strMpl.GetUsername();

            Assert.Equal(stringExpected.Length, stringGenerated.Length);
            Assert.Equal(stringExpected, stringGenerated);
        }
        
        [Fact]
        public void GetPassword_ShouldReturn_Password()
        {
            StringManipulation strMpl = new StringManipulation(testString);

            string stringExpected = "Is@bnkh5$@bvj";
            string stringGenerated = strMpl.GetPassword();

            Assert.Equal(stringExpected.Length, stringGenerated.Length);
            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void SplitElements_ShouldReturn_SplitedElements()
        {
            StringManipulation strMpl = new StringManipulation(testString);
            string[] splitedElementsArrayExpected = { "1", "Social Media", "Instagram", "Cadu", "Is@bnkh5$@bvj" };
            string[] splitedElementsArrayGenerated = strMpl.SplitElements();

            Assert.Equal(splitedElementsArrayExpected.Length, splitedElementsArrayGenerated.Length);
            Assert.Equal(splitedElementsArrayExpected, splitedElementsArrayGenerated);

        }
    }
}
