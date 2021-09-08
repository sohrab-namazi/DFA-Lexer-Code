using System;
using System.Collections.Generic;
using System.Text;

namespace FSA
{
    public class FA
    {
        public int StateCount;
        public List<State> States;
        public State FinalState;

        public FA(int n)
        {
            StateCount = n;
            States = new List<State>();
            for (int i = 0; i < StateCount; i++) States.Add(new State(i));
        }

        public void SetFinalState(int n)
        {
            States[n].IsFinal = true;
            FinalState = States[n];
        }
    }

    public class State
    {
        public string Number = "q";
        public List<Edge> OutTransitions;
        public bool IsFinal = false;

        public State(int n)
        {
            this.Number += n;
            OutTransitions = new List<Edge>();
        }

        public void AddTransition(char a, State state)
        {
            OutTransitions.Add(new Edge(a, state));
        }

        public Edge HasTransition(char a)
        {
            foreach (Edge edge in OutTransitions)
            {
                if (edge.Character.Equals(a))
                {
                    return edge;
                }
            }
            return null;
        }

    }

    public class Edge
    {
        public char Character;
        public State OutState;

        public Edge(char c, State state)
        {
            this.Character = c;
            this.OutState = state;
        }
    }
}
