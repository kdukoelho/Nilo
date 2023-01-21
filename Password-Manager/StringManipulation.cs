using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public class StringManipulation
    {
        private string inputString;
        private int openedBracketIndex;  private int closedBracketIndex;
        private int lastOpenedBracketIndex; private int lastClosedBracketIndex;
        private int minusIndex; private int equalIndex;
        public StringManipulation(string inputString)
        {
            this.inputString = inputString;
            this.closedBracketIndex = inputString.IndexOf(']');
            this.openedBracketIndex = inputString.IndexOf('[');
            this.lastOpenedBracketIndex = inputString.LastIndexOf('[');
            this.minusIndex = inputString.IndexOf('-');
            this.equalIndex = inputString.IndexOf('=');
        }
        public string GetId() 
        {
           
            return inputString.Substring(0, minusIndex - 1);
        }
        public string GetGroup() 
        {
            return inputString.Substring(openedBracketIndex + 2, closedBracketIndex - 7); ;
        }
        public string GetTittle()
        {
            return inputString.Substring(closedBracketIndex + 2, lastOpenedBracketIndex - closedBracketIndex - 3);
        }
        public string GetUsername()
        {
            return inputString.Substring(lastOpenedBracketIndex + 2, equalIndex - lastOpenedBracketIndex - 5);
        }
        public string GetPassword()
        {
            return inputString.Substring(equalIndex + 2);
        }
        public string GetStringWithoutGroup()
        {
            return inputString.Substring(closedBracketIndex + 2);
        }
        public string[] SplitElements()
        {
            string[] splitedElemts = { GetId(), GetGroup(), GetTittle(), GetUsername(), GetPassword() };
            return splitedElemts;
        }
    }
}
