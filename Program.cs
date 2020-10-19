using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_challenge
{
    class Program
    {

        private Dictionary<string, string> phrases = new Dictionary<string, string>()
                        {
                                {"Hello", "Ellohay"},
                                {"Pig Latin", "Igpay Atinlay"},
                                {"The first month is Janurary", "Ethay irstfay onthmay isway Anuraryjay"},
                                {"The floor is sticky", "Ethay oorflay isway ickystay"}
                        };

        static void Main(string[] args)
        {
            new Program();

        }

        public Program()
        {
            foreach (var pair in phrases)
            {
                testEquals(pair.Key, pair.Value, translateEnglishToPigLatin(pair.Key));
            }
        }

        private string translateEnglishToPigLatin(string english)
        {

            string UserInput = Console.ReadLine();

            //store all 'UserInput' in character array 'charArray'
            char[] charArray = UserInput.ToCharArray();

            string Piglatin = "";
            char firstchar;
            string firstTwoChars = "";
            string lastchars = "";
            string ArrToString = "";

            //if input starts with a vowel - concatenate with 'way'
            if ((charArray[0] == 'a') || (charArray[0] == 'e') || (charArray[0] == 'i') || (charArray[0] == 'o') || (charArray[0] == 'u'))
            {
                //convert array to string
                ArrToString = new string(charArray);
                
                //the piglatinword
                Piglatin = ArrToString + "way";

                
            }

            else { }

            //if input has 2 consonents at the beginning - move both consonents to the end and add 'ay'
            if ((charArray[0] != 'a') & (charArray[0] != 'e') & (charArray[0] != 'i') & (charArray[0] != 'o') & (charArray[0] != 'u') &&
                (charArray[1] != 'a') & (charArray[1] != 'e') & (charArray[1] != 'i') & (charArray[1] != 'o') & (charArray[1] != 'u'))
            {
                //convert array to string  
                ArrToString = new string(charArray);
             
                //store the first two characters in 'firstTwoChars'
                firstTwoChars = ArrToString.Substring(0, 2);
             
                //store the remaining cahracters in 'lastchars'
                lastchars = ArrToString.Substring(2);
                Piglatin = lastchars + firstTwoChars + "ay";
            }

            else
            {   //if input has 1 consonent at the beginning - move the consonent to the end and add 'ay'
                if ((charArray[0] != 'a') & (charArray[0] != 'e') & (charArray[0] != 'i') & (charArray[0] != 'o') & (charArray[0] != 'u'))

                {
                    //first character (index [0]) is stored in 'firstchar'
                    firstchar = charArray[0];
                
                    //drop the first character from the array
                    charArray = charArray.Skip(1).ToArray();
                    
                    //the piglatin word is the new array + the first character + 'ay'
                    Piglatin = ((String.Join("", charArray) + firstchar + "ay"));
                }

                else { }

            }
            return Piglatin;

            
        }

        private void testEquals(string input, string expect, string actual)
        {
            if (expect.ToLower() == actual.ToLower())
            {
                if (expect != expect.ToLower() && expect == actual)
                {
                    Console.WriteLine("PASS (Bonus)! {0} -> {1}", input, actual);
                }
                else
                {
                    Console.WriteLine("PASS! {0} -> {1}", input, actual);
                }
            }
            else
            {
                Console.WriteLine("FAIL!");
                Console.WriteLine("  Input: {0}", input);
                Console.WriteLine("  Expect: {0}", expect);
                Console.WriteLine("  Actual: {0}", actual);
            }

              Console.ReadKey();
        }

    }
}