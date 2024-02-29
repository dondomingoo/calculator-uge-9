namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Calculator calculator = new Calculator(); // Opretter et nyt objekt af Calculator klassen.
            bool keepRunning = true;
            do
            {
                Console.WriteLine("Velkommen til team 9's lommeregner");
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Indtast det første tal :");
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vælg hvilken operation du vil udføre ( +, -, *, / ) ");
                    string operation = Console.ReadLine();
                    Console.Write("Indtast det andet tal :");
                    int b = int.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine("Resultatet er: " + calculator.Add(a, b)); // Kalder Add metoden fra calculator objektet og udskriver resultatet.
                            break;
                        case "-":
                            Console.WriteLine("Resultatet er: " + calculator.Subtract(a, b)); // Kalder Subtract metoden fra calculator objektet og udskriver resultatet.
                            break;
                        case "*":
                            Console.WriteLine("Resultatet er: " + calculator.Multiply(a, b));
                            break;
                        case "/":
                            Console.WriteLine("Resultatet er: " + calculator.Divide(a, b));
                            break;
                        default:
                            Console.WriteLine("Ugyldig operation");
                            break;

                    }

                }
                catch (FormatException e) // Hvis brugeren indtaster noget andet end et tal, vil vi fange FormatException og udskrive en fejlbesked.
                {
                    Console.WriteLine("Ugyldigt input, prøv igen");
                    continue;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Du kan ikke dividere med 0");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Der skete en fejl, prøv igen");
                    continue;
                }
        
                    Console.WriteLine("Vil du prøve igen? (ja/nej)");
                    Console.WriteLine("---------------------------------------------------");
                    string answer = Console.ReadLine();
                    Console.Clear();
                    if (answer.ToLower() == "nej")
                    {
                        keepRunning = false;
                    }
                
            }
            while (keepRunning);

            Console.WriteLine("Farvel");
        }

    }
}   
 




//Console.WriteLine(calculator.Add(5, 3));
            //Console.WriteLine(calculator.Subtract(5, 3));
            //Console.WriteLine(calculator.Multiply(5, 3)); // denne 
            //Console.WriteLine(calculator.Divide(5, 3)); // denne metode returnerer 1.0, da vi deler to integers, og derfor returnerer den en integer.
            //Console.ReadKey();
