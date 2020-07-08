using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    private static int inputSize = 0;

    public static void processInput(string input)
    {
        if (input.Length == 1)
        {
            inputSize = int.Parse(input);
        }
        else
        {
            var s = input.Split(' ');
            string text = s[1];
            int passwordLenght = int.Parse(s[0].ToString());

            var str = new List<string>();

            for (int index = 0; index < text.Length; index++)
            {
                try
                {
                    str.Add(text.Substring(index, passwordLenght));
                }
                catch (Exception e)
                {

                }

            }

            var query = str.GroupBy(x => x)
                            .Select(group => new { Location = group.Key, Count = group.Count() })
                            .OrderByDescending(x => x.Count);

            Console.WriteLine(query.First().Location);
        }
    }

    //Este e um exemplo de processamento de entradas (inputs), sinta-se a vontade para altera-lo conforme necessidade da questao.
    public static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            processInput(line);
        }
    }
}