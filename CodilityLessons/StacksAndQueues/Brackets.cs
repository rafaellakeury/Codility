using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityLessons.StacksAndQueues
{
    public class Brackets
    {
        public int Solution(string S)
        {
            if(S == null) return 0;
            if(S.Length == 0) return 1;
            List<char> stringList = new List<char>();
            foreach(char element in S)
            {

                if(element.Equals('(') || element.Equals('{') || element.Equals('['))
                {
                    stringList.Add(element);
                }
                else
                {
                    var openingElement = stringList.LastOrDefault();
                    if(stringList.Any())
                    {
                        stringList.RemoveAt(stringList.Count - 1);
                    }
                    if(element.Equals(')') && !openingElement.Equals('(')) 
                        return 0;
                    if(element.Equals('}') && !openingElement.Equals('{'))
                        return 0;
                    if(element.Equals(']') && !openingElement.Equals('['))
                        return 0;
                }   
            }
            if(stringList.Count == 0)
            {
                return 1;
            }
            return 0;
        }
    }
}