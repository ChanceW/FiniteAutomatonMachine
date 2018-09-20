using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteAutomatonMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var state1 = new State() { Id = 1, Name = "q0", IsAcceptance = false };
            var state2 = new State() { Id = 2, Name = "q1", IsAcceptance = true  };
            var dfa = new Machine();
            dfa.States.Add(state1.Id, state1);
            dfa.States.Add(state2.Id, state2);

            
            
            state1.Transitions.Add('0', state1.Id);
            state1.Transitions.Add('1', state2.Id);

            state2.Transitions.Add('0', state2.Id);
            state2.Transitions.Add('1', state1.Id);

            var input = "011001101";
            var path = dfa.ProcessString(input);
            Console.WriteLine($"Input {input}");
            Console.WriteLine(String.Join(", ", path.Select(x => x.Name)));
            Console.WriteLine($"IsAccepted: {path.Last().IsAcceptance}");
            Console.WriteLine();

            input = "0110011";
            path = dfa.ProcessString(input);
            Console.WriteLine($"Input {input}");
            Console.WriteLine(String.Join(", ", path.Select(x => x.Name)));
            Console.WriteLine($"IsAccepted: {path.Last().IsAcceptance}");
            Console.WriteLine();

            input = "011";
            path = dfa.ProcessString(input);
            Console.WriteLine($"Input {input}");
            Console.WriteLine(String.Join(", ", path.Select(x => x.Name)));
            Console.WriteLine($"IsAccepted: {path.Last().IsAcceptance}");
            Console.WriteLine();

            Console.WriteLine($"The language was [{String.Join(", ", dfa.GetLanguage())}]");
            Console.ReadLine();
        }
    }
}
