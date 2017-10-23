using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression.Expression queryExpression = null;

            Console.Write("Type the query: ");
            string query = Console.ReadLine();

            try
            {
                queryExpression = Expression.Expression.Analize(query);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                queryExpression = null;
            }

            if (queryExpression != null)
            {
                Console.WriteLine("Type the vehicle description: ");
                string description = Console.ReadLine();

                if (queryExpression.Evaulate(description))
                    Console.WriteLine("the description responds to the query.");
                else
                    Console.WriteLine("the description doest not respond to the query.");
            }

            Console.ReadKey();
        }
    }
}
