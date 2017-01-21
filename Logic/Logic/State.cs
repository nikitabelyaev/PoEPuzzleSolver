using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class State
    {
        public bool[] state;
        public string history;
        public string stateValue{
            get{
                string val="";
                foreach(bool s in state){
                    if(s){
                        val+="1";
                    }
                    else{
                        val+="0";
                    }
                }
                return val;
            }
        }

    
        
        

        public void addToHistory(int index){
            history = history + " " + index.ToString();
        }

        public State(bool[] state)
        {
            this.state = state;
        }

        public State(bool[] state, string history)
        {
            this.state = state;
            this.history = history;
        }

        public State()
        {
            state = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                state[i] = true;
            }
        }


        public  bool Equals(State obj)
        {
            for (int i =0; i<8;i++)
            {
                if (state[i] != obj.state[i])
                {
                    return false;
                }
            }
            
            
            
            return true;
        }

        //public string ToString()
        //{
        //    string 
        //}
        
    }
}
