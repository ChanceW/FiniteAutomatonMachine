using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteAutomatonMachine
{
    class State
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsAcceptance { get; set; }

        public Dictionary<char, int> Transitions { get; set; } = new Dictionary<char, int>();
    }
}
