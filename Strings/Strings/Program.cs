using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            string opening = "Hi my name is David ";
            string middle = "I am 26 years old ";
            string end = "and I am a student of Pitman Training";
            string sentence = string.Concat(opening, middle, end);

            string testString = "converted to upper case";
            testString.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is David.");
            sb.Append("I am 26 years old.");
            sb.Append("I am a student of Pitman Training.");
            sb.Append("I am currently studying for my advanced software and web development diploma.");

            Console.WriteLine(sentence);
            Console.WriteLine(testString);
            Console.WriteLine(sb);
        }
    }
}
