using System.Xml.Serialization;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool exitRequested = false;

            while (!exitRequested)
            {
                Console.WriteLine("what was your favorite subject in Wizardy school?\nIf you like to leave type Exit");

                Console.WriteLine();

                string userChoice = Console.ReadLine();

                string captalizeInput = CapsFirstLetter(userChoice);
                Console.WriteLine(captalizeInput);

                switch (userChoice)
                {
                    case "Potions":
                        Console.WriteLine("Yes the mixing of tonics is very exciting.");
                        break;

                    case "Herbology":
                        Console.WriteLine("Plants are very helpful and have many uses.");
                        break;

                    case "Divination":
                        Console.WriteLine("Hmm yes seeing into toe future can be very useful.");
                        break;

                    case "Charms":
                        Console.WriteLine("Yes the fundimentals of any basic wizard.");
                        break;

                    case "Astronomy":
                        Console.WriteLine("Yes stduy of the stars very mathmaticle mind you have.");
                        break;
                    case "Muggle Studies":
                        Console.WriteLine("Very interesting creatures those muggles arn't they.");
                        break;
                    case "Care of Magical Creatures":
                        Console.WriteLine("Very rewarding taking care of them is it not.");
                        break;
                    case "Flying":
                        Console.WriteLine("Ahh future Quidditch star or broom maker maybe! ");
                        break;

                    case "Exit":
                        exitRequested = true;
                        break;

                    default:
                        Console.WriteLine("Sorry that is not class in Hogwarts please choose from\nPotions,Herbology\nDivination,Charms\nAstronomy,Muggle Studies\nCare of Magical Creatures,Flying");
                        break;
                }
            }
            static string CapsFirstLetter(string userInput)
            {
                if (string.IsNullOrEmpty(userInput))
                    return userInput;

                return char.ToUpper(userInput[0]) + userInput.Substring(1);
            }

        }

    }
}
