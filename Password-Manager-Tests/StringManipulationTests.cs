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
            Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(testString);

            string stringExpected = "1";
            string stringGenerated = strMpl.GetId();

            Assert.Equal(stringExpected, stringGenerated);
        }
        [Fact]
        public void GetGroup_ShouldReturn_Group()
        {
            Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(testString);

            string stringExpected = "Social Media";
            string stringGenerated = strMpl.GetGroup();

            Assert.Equal(stringExpected, stringGenerated);
        }
        [Fact]
        public void GetTittle_ShouldReturn_Tittle()
        {
            Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(testString);

            string stringExpected = "Instagram";
            string stringGenerated = strMpl.GetTittle();

            Assert.Equal(stringExpected, stringGenerated);
        }
        [Fact]
        public void GetUsername_ShouldReturn_Username()
        {
            Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(testString);

            string stringExpected = "Cadu";
            string stringGenerated = strMpl.GetUsername();

            Assert.Equal(stringExpected, stringGenerated);
        }
        [Fact]
        public void GetPassword_ShouldReturn_Password()
        {
            Password_Manager.StringManipulation strMpl = new Password_Manager.StringManipulation(testString);

            string stringExpected = "Is@bnkh5$@bvj";
            string stringGenerated = strMpl.GetPassword();

            Assert.Equal(stringExpected, stringGenerated);
        }
    }
}
