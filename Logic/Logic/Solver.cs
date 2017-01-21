using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Logic
{
    class Solver
    {
        private State goal = new State();

        public string solveBFS(bool[] state){
            Queue<State> states = new Queue<State>();
            State initial = new State(state);
            UILogic logic = new UILogic();



            if (initial.Equals(goal))
            {
                return "already solved m8";
            }

            states.Enqueue(initial);
            //solveBFS(states);
            State current; 
            while (states.Count > 0)
            {
                current = states.Dequeue();
                for (int i = 0; i < 8; i++)
                {
                    bool[] next = logic.nextGameState(current.state, i);
                    string hist = current.history +" "+i;
                    State newState = new State(next,hist);

                    if (newState.Equals(goal))
                    {
                        return newState.history;
                    }
                    else
                    {
                        states.Enqueue(newState);
                    }
                }
            }

            return "No solution was found";

        }

        private void solveBFS(Queue<State> states)
        {

            while (states.Count > 0)
            {

            }
        }
    }
}
