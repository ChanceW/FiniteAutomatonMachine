using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteAutomatonMachine
{
    class Machine
    {
        public Dictionary<int, State> States { get; set; } = new Dictionary<int, State>();

        public List<State> ProcessString(string input) {
            var currentState = this.States.First().Value;
            var path = new List<State>() { currentState };

            var symbols = input.ToCharArray();
            foreach (var s in symbols) {
                currentState = this.States[currentState.Transitions[s]];
                path.Add(currentState);
            }
            return path;
        }

        public char[] GetLanguage() {
            var result = new List<char>();
            foreach (var state in this.States) {
                foreach(var c in state.Value.Transitions.Keys){
                    result.Add(c);
                }
            }
            return result.Distinct().ToArray();
        }
    }
}
