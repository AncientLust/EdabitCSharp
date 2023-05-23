using System.Data;
using System.Text;

class PrefixNotationEvaluation
{
    public static int Prefix(string exp)
    {
        string[] args = exp.Split(' ');

        // Collect char operators
        List<char> operators = new List<char>();
        int i = 0;
        while (i < args.Length && !int.TryParse(args[i], out int intValue))
        {
            if (args[i].Length == 1)
                operators.Add(args[i][0]);
            else
            {
                Console.WriteLine($"Invalid operator: {args[i]}");
                return 0;
            }
            i++;
        }

        // Collect numeric operands
        List<int> operands = new List<int>();
        while (i < args.Length)
        {
            if (int.TryParse(args[i], out int operandValue))
                operands.Add(operandValue);
            else
            {
                Console.WriteLine($"Invalid operand: {args[i]}");
                return 0;
            }
            i++;
        }

        // Validate operators and operands count
        if (operators.Count != operands.Count - 1)
        {
            Console.WriteLine("Mismatched number of operators and operands");
            return 0;
        }

        // Initialize a StringBuilder to build the expression
        StringBuilder expressionBuilder = new StringBuilder(operands[0].ToString());

        // Append the remaining operators and operands
        for (i = 0; i < operators.Count; i++)
        {
            expressionBuilder.Append(operators[i]);
            expressionBuilder.Append(operands[i + 1]);
        }

        // Compute the expression
        var result = new DataTable().Compute(expressionBuilder.ToString(), null);
        return Convert.ToInt32(result);
    }
}
