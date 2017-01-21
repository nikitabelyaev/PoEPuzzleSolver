using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class UILogic
    {
        private bool[] state = new bool[8];

        public UILogic()
        {
            initializeState();
        }

        private void initializeState()
        {
            for(int i =0; i<8; i++){
                state[i] =false;
            }
        
        }

        public bool[] getNextState(bool setup, int switchNum)
        {
            if (setup)
            {
                state[switchNum] = !state[switchNum];

            }
            else
            {
                //for (int i = -1; i < 2; i++)
                //{
                    
                //    //int index = 8%i;
                //    int index = mod(switchNum+ i,8);
                //    state[index] = !state[index];
                //}
                state = nextGameState(state, switchNum);
            }
            return state;
        }

        public string solveBFS()
        {
            Solver solver = new Solver();
            return solver.solveBFS(state);
        }

        public bool[] nextGameState(bool[] prev, int switchNum)
        {
            bool[] next = new bool[8];

            for (int i = 0; i < 8; i++)
            {
                next[i] = prev[i];
            }

            //next = prev;
            for (int i = -1; i < 2; i++)
            {

                //int index = 8%i;
                int index = mod(switchNum + i, 8);
                next[index] = !prev[index];
            }
            return next;
        }

        private int mod(int x, int m)
        {
            return (x % m + m) % m;
        }
    }
}
