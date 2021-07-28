using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Recursion
{
    public static class LetterCombinationsPhone
    {
        public static List<string> LetterCombinations(string digits)
        {
            List<string> results = new List<string>();

            Dictionary<string, char[]> alphaCombinations = new Dictionary<string, char[]>();
            alphaCombinations.Add("2", new[] { 'a', 'b', 'c' });
            alphaCombinations.Add("3", new[] { 'd', 'e', 'f' });
            alphaCombinations.Add("4", new[] { 'g', 'h', 'i' });
            alphaCombinations.Add("5", new[] { 'j', 'k', 'l' });
            alphaCombinations.Add("6", new[] { 'm', 'n', 'o' });
            alphaCombinations.Add("7", new[] { 'p', 'q', 'r', 's' });
            alphaCombinations.Add("8", new[] { 't', 'u', 'v' });
            alphaCombinations.Add("9", new[] { 'w', 'x', 'y', 'z' });
            
            if(digits != string.Empty)
            {
                var firstDigit = digits.ToList()[0];
                var secondDigit = digits.ToList()[1];

                var firstNum = alphaCombinations.FirstOrDefault(x => x.Key == firstDigit.ToString());
                var secondNum = alphaCombinations.FirstOrDefault(x => x.Key == secondDigit.ToString());
                string tmp = string.Empty;
                for(int i = 0; i < firstNum.Value.Length; i++)
                {
                    //Console.WriteLine(firstNum.Value[i]);
                    tmp = firstNum.Value[i].ToString() + secondNum.Value[i].ToString();
                    Console.WriteLine(tmp);
                    results.Add(tmp);
                }
            }   
            return results;






        }

       
    }
}
