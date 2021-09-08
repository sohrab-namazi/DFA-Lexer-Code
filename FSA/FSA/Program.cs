using System;
using System.Collections.Generic;

namespace FSA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> alphabets = new List<char>();
            List<int> FinalStates = new List<int>();
            int stateCount = 0;

            //edit top variables    
            stateCount = 5;
            alphabets.Add('0');
            alphabets.Add('1');
            FinalStates.Add(0);
            FinalStates.Add(1);
            FinalStates.Add(2);
            FinalStates.Add(3);

            Language language = new Language(stateCount);
            language.setAlphabet(alphabets);
            language.setFinalState(FinalStates);

            // add transitions
            language.addTransition(0, 0, '0');
            language.addTransition(0, 1, '1');
            language.addTransition(1, 0, '0');
            language.addTransition(1, 2, '1');
            language.addTransition(2, 3, '0');
            language.addTransition(3, 0, '0');
            language.addTransition(3, 4, '1');
            language.addTransition(4, 4, '0');
            language.addTransition(4, 4, '1');

            Console.WriteLine("Enter you input:");
            string input = Console.ReadLine();
            string result = language.CheckString(input);
            Console.WriteLine(result);

        }
    }
}
