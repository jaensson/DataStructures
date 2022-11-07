using DataStructures;
using System.Collections;

internal class Program
{
    public static void Main(string[] args)
    {
        // Uppgift 1: Stack - LIFO
        Console.WriteLine("Uppgift 1.1: " + ReverseString("SNAKE"));

        string ReverseString(string input)
        {
            string result = String.Empty;
            Stack<char> stack = new Stack<char>();

            for(int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            for(int i = 0; i < input.Length; i++)
            {
                result += stack.Pop();
            }

            return result;
        }

        // Uppgift 2: Stack - LIFO, Kollar om nästa stängda motsvarar den senaste öppna
        Console.WriteLine("Uppgift 2.1: " + IsBalancedBrackets("[()]{}{[()()]()}"));
        Console.WriteLine("Uppgift 2.2: " + IsBalancedBrackets("[(])"));

        string IsBalancedBrackets(string input)
        {
            List<char> openBrackets = new List<char> { '(', '[', '{' };
            List<char> closedBrackets = new List<char> { ')', ']', '}' };

            Stack<char> stack = new Stack<char>();

            for(int i = 0; i < input.Length; i++)
            {
                if(openBrackets.Contains(input[i]))
                {
                    stack.Push(input[i]);
                }

                if(closedBrackets.Contains(input[i])) {
                    char value = stack.Peek();

                    if(value == '(' && input[i] == ')')
                    {
                        stack.Pop();
                    } else if(value == '[' && input[i] == ']')
                    {
                        stack.Pop();
                    } else if(value == '{' && input[i] == '}')
                    {
                        stack.Pop();
                    } else
                    {
                        return "Den är inte balanserad";
                    }
                }
            }

            return "Den är balanserad";
        }

        // Uppgift 3: Stack - LIFO
        Console.WriteLine("Uppgift 3.1: " + GetResult("*+15-42"));

        int GetResult(string input)
        {
            Stack<char> stack = new Stack<char>();
            int total = 0;
            int tal1 = 0;
            int tal2 = 0;

            for(int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            bool counting = true;

            while(counting)
            {
                if(tal1 != 0 && tal2 != 0)
                {
                    char method = stack.Pop();

                    if(method == '*')
                    {
                        total = tal1 * tal2;
                    }

                    counting = false;
                } else
                {
                    int firstValue = int.Parse(char.ConvertFromUtf32(stack.Pop()));
                    int secondValue = int.Parse(char.ConvertFromUtf32(stack.Pop()));
                    char method = stack.Pop();
                    int result = 0;

                    if(method == '-')
                    {
                        result = secondValue - firstValue;
                    }
                    if(method == '+')
                    {
                        result = secondValue + firstValue;
                    }

                    if(tal1 == 0)
                    {
                        tal1 = result;
                    } else
                    {
                        tal2 = result;
                    }
                }
            }

            return total;
        }

        // Uppgift 4.1: Set, Returnerar det första värdet som upprepas
        int[] array = new int[] { 1, 6, 4, 1, 4, 2, 7, 4, 6 };
        Console.WriteLine("Uppgift 4.1: " + FirstRepeatedDigit(array));
        Console.WriteLine("Uppgift 4.2: " + RepeatedDigits(array));

        string FirstRepeatedDigit(int[] input)
        {
            string result = "Finns inga dubbletter!";
            HashSet<int> set = new HashSet<int>();

            for(int i = 0; i < input.Length; i++)
            {
                if(!set.Add(input[i]))
                {
                    return "Det första värdet som upprepats är: " + input[i].ToString();
                }
            }

            return result;
        }

        // Uppgift 4.2: Set, Dictionary
        string RepeatedDigits(int[] input)
        {
            string result = "Finns inga dubbletter!";
            HashSet<int> set = new HashSet<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();

            for(int i = 0; i < input.Length; i++)
            {
                if(!set.Add(input[i]))
                {
                    map[input[i]] = map[input[i]] + 1;
                    result = "De tal som upprepats två gånger är: ";
                } else
                {
                    map.Add(input[i], 1);
                }
            }

            foreach(KeyValuePair<int, int> element in map)
            {
                if(element.Value == 2)
                {
                    result += element.Key + ", ";
                }
            }

            return result;
        }

        // Uppgift 5: Set
        array = new int[] { 0, -1, 2, -3, 1, 8, -10, -100, 98, 40, 12, -50, -14 };
        Console.WriteLine("Uppgift 5.1: " + Sum(array));

        string Sum(int[] input)
        {
            int sum = -2;
            string result = "Det finns inga tal som adderar till: " + sum;
            HashSet<string> set = new HashSet<string>();

            for(int i = 0; i < input.Length; i++)
            {
                for(int j = 0; j < input.Length; j++)
                {
                    if(i == j)
                    {
                        break;
                    }
                    if(input[i] + input[j] == sum)
                    {
                        if (input[i] > input[j])
                        {
                            set.Add(input[i] + " + " + input[j]);
                        } else
                        {
                            set.Add(input[j] + " + " + input[i]);
                        }
                        
                        result = "De tal som adderar till " + sum + " är: ";
                    }
                }
            }

            foreach(var item in set)
            {
                result += item + ", ";
            }

            return result;
        }

        // SLUTET PÅ UPPGIFTERNA



        // Egen stack
        Stacken<char> s = new Stacken<char>();
        string word = "SNAKE";

        foreach(char character in word)
        {
            s.Push(character);
        }

        for(int i = s.Count; i > 0; i--)
        {
            Console.Write(s.Pop());
        }
        Console.WriteLine();

        /*for(int i = 0; i < word.Length; i++)
        {
            Console.Write(s.Pop());
        }*/

        // Egen 

        LinkedListan<int> list = new LinkedListan<int>();

        list.AddLast(2);
        

        list.AddFirst(1);

        list.Print();


        Console.WriteLine();


        
    }
}