using System;
using System.Linq;

namespace Leetspeak
{
  public class LeetspeakTranslator
  {
    public string Translate(string myString)
    {
      char[] myStringArray = myString.ToCharArray();

      for (int index = 0; index < myStringArray.Length; index++)
      {
        if (myStringArray[index] == 'e')
        {
          myStringArray[index] = '3';
        }
        else if (myStringArray[index] == 'o')
        {
          myStringArray[index] = '0';
        }
        else if (myStringArray[index] == 'I')
        {
          myStringArray[index] = '1';
        }
        else if (myStringArray[index] == 't')
        {
          myStringArray[index] = '7';
        }
        else if (myStringArray[index] == 's' && index != 0 && myStringArray[index-1] != ' ')
        {
          myStringArray[index] = 'z';
        }
      }

      string result = string.Join("", myStringArray);

      return result;
    }

    public void Main()
    {
      Console.WriteLine("Enter a string to translate:");

      string myString = Console.ReadLine();

      string myNewString = Translate(myString);

      Console.WriteLine("Translation: " + myNewString);
    }
  }
}
