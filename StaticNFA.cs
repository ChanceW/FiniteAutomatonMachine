using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(String.Join(", ", StaticNFA.ProcessString("000011000011000")));
	}
}

public static class StaticNFA{
	public static List<string> ProcessString(string input){
		var result = new List<string>();
		for(int i = 0; i < input.Length; i++){
			if(i == input.Length -1 && input[i] == '0'){
				result.Add((input[i] == '0')? "q2" : "q1");
			}
			else if(input[i] == '1' && i == input.Length - 2){
				result.Add("q1");
			}
			else if(input[i] == '1' && i != input.Length - 2 && input[i + 1] == '0'){
				result.Add("q1");
				result.Add("fail");
				break;
			}
			else
				result.Add("q0");
		}
		return result;
	}
}