using System;
using System.Collections.Generic;
using System.Text;

namespace FSA
{
        public class Language
        {
            public FA FA;
            public List<char> Alphabets;
            public int stateCount;

            // 1
            public Language(int stateCount)
            {
                this.stateCount = stateCount;
                FA = new FA(stateCount);
                Alphabets = new List<char>();
            }

            // 2
            public void setAlphabet(List<char> alphabet)
            {
                  this.Alphabets = alphabet;
            }

            // 3
            public void addTransition(int startState, int endState, char c)
            {
                 FA.States[startState].AddTransition(c, FA.States[endState]);
            }

            // 4
            public void setFinalState(List<int> ss)
            {
                 foreach (int s in ss)
                 {
                     this.FA.SetFinalState(s);
                 }
            }

            public string CheckString(string w)
            {
                State CurrentState = FA.States[0];
                string Output = "\n";

                foreach (char c in w)
                {
                    Edge edge = CurrentState.HasTransition(c);
                    if (edge != null)
                    {
                        Output += "CurrentState : " + CurrentState.Number + "\nReading : " + edge.Character + "\n";
                        CurrentState = edge.OutState; 
                    }
                    else
                    {
                        Output = "Rejected";
                        return Output;
                    }
                    Output += "\n";
                }

                Output += "Current state : " + CurrentState.Number + "\nString Finished"; 

                if (CurrentState.IsFinal)
                {
                    Output = "Accepted\n" + Output;
                    return Output;
                } 
                Output = "Rejected";
                return Output;
            }
        }

}
