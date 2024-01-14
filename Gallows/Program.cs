using System;
using System.IQ;
using System.Linq;

namespace Šibenice_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("Slova.txt");
            string[] englishWords = File.ReadAllLines("Words.txt");

            Console.Write("Zadejte jazyk příkazem: čeština / Choose language with english: ");
            string language = Console.ReadLine();
            switch (language)
            {
                case "čeština":
                    while (true)
                    {
                        Console.Write("Pro zahrání šibenice zadejte play, pro ukončení exit: ");
                        string start = Console.ReadLine();
                        switch (start)
                        {

                            case "play":
                                Console.Write("Zadejte, jestli chcete hrát sám, nebo s kamarádem. Pro hraní sám zadejte single, pro více zadejte multi: ");
                                string type = Console.ReadLine();
                                switch (type)
                                {
                                    case "multi":
                                        Console.Clear();
                                        Console.Write("Zadejte slovo, které chcete, aby Váš kamarád hádal: ");
                                        string input = Console.ReadLine();
                                        string copyInput = input;
                                        int lives = 10;
                                        string wrong = "";
                                        do
                                        {
                                            string trueFalse = "";
                                            Console.Clear();
                                            Console.WriteLine("Počet životů: " + lives);
                                            for (int i = 0; i < input.Length; i++)
                                            {
                                                if (copyInput.Contains(input[i]))
                                                {
                                                    Console.Write("_ ");
                                                }
                                                else
                                                {
                                                    Console.Write(input[i] + " ");
                                                }
                                            }
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine("Špatné pokusy byly: " + wrong);
                                            Console.Write("Zadejte písmeno: ");

                                            char findChar = Console.ReadKey().KeyChar;
                                            char[] inputArray = input.ToCharArray();
                                            foreach (char c in inputArray)
                                            {
                                                if (findChar == c)
                                                {
                                                    trueFalse = "true";
                                                    copyInput = copyInput.Replace(c.ToString(), "");
                                                }
                                            }
                                            if (trueFalse != "true")
                                            {
                                                lives--;
                                                wrong += findChar + ", ";
                                            }

                                        } while (lives > 0 && copyInput != "");
                                        Console.Clear();
                                        if (lives > 0)
                                        {
                                            Console.WriteLine("Vyhrál jste, slovo bylo: " + input);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Prohrál jste, slovo bylo: " + input);
                                        }
                                        break;

                                    case "single":
                                        Random word = new Random();
                                        int index = word.Next(words.Length);
                                        Console.Clear();
                                        string inputMulti = words[index];
                                        string copyInputMulti = inputMulti;
                                        int livesMulti = 10;
                                        string wrongMulti = "";
                                        do
                                        {
                                            string trueFalse = "";
                                            Console.Clear();
                                            Console.WriteLine("Počet životů: " + livesMulti);
                                            for (int i = 0; i < inputMulti.Length; i++)
                                            {
                                                if (copyInputMulti.Contains(inputMulti[i]))
                                                {
                                                    Console.Write("_ ");
                                                }
                                                else
                                                {
                                                    Console.Write(inputMulti[i] + " ");
                                                }
                                            }
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine("Špatné pokusy byly: " + wrongMulti);
                                            Console.Write("Zadejte písmeno: ");

                                            char findCharMulti = Console.ReadKey().KeyChar;
                                            char[] inputArrayMulti = inputMulti.ToCharArray();
                                            foreach (char c in inputArrayMulti)
                                            {
                                                if (findCharMulti == c)
                                                {
                                                    trueFalse = "true";
                                                    copyInputMulti = copyInputMulti.Replace(c.ToString(), "");
                                                }
                                            }
                                            if (trueFalse != "true")
                                            {
                                                livesMulti--;
                                                wrongMulti += findCharMulti + ", ";
                                            }

                                        } while (livesMulti > 0 && copyInputMulti != "");
                                        Console.Clear();
                                        if (livesMulti > 0)
                                        {
                                            Console.WriteLine("Vyhrál jste, slovo bylo: " + inputMulti);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Prohrál jste, slovo bylo: " + inputMulti);
                                        }
                                        break;

                                }
                                break;


                            case "exit":
                                return;
                        }

                    }
                case "english":
                    while (true)
                    {
                        Console.Write("For play this game write play, for exit write exit:  ");
                        string start = Console.ReadLine();
                        switch (start)
                        {

                            case "play":
                                Console.Write("If you want to play alone, write single, if you want to play with your friend, write multi: ");
                                string type = Console.ReadLine();
                                switch (type)
                                {
                                    case "multi":
                                        Console.Clear();
                                        Console.Write("Write word for your friend.");
                                        string input = Console.ReadLine();
                                        string copyInput = input;
                                        int lives = 10;
                                        string wrong = "";
                                        do
                                        {
                                            string trueFalse = "";
                                            Console.Clear();
                                            Console.WriteLine("Lives: " + lives);
                                            for (int i = 0; i < input.Length; i++)
                                            {
                                                if (copyInput.Contains(input[i]))
                                                {
                                                    Console.Write("_ ");
                                                }
                                                else
                                                {
                                                    Console.Write(input[i] + " ");
                                                }
                                            }
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine("Wrong attempts was: " + wrong);
                                            Console.Write("Enter a letter: ");

                                            char findChar = Console.ReadKey().KeyChar;
                                            char[] inputArray = input.ToCharArray();
                                            foreach (char c in inputArray)
                                            {
                                                if (findChar == c)
                                                {
                                                    trueFalse = "true";
                                                    copyInput = copyInput.Replace(c.ToString(), "");
                                                }
                                            }
                                            if (trueFalse != "true")
                                            {
                                                lives--;
                                                wrong += findChar + ", ";
                                            }

                                        } while (lives > 0 && copyInput != "");
                                        Console.Clear();
                                        if (lives > 0)
                                        {
                                            Console.WriteLine("You won, word was: " + input);
                                        }
                                        else
                                        {
                                            Console.WriteLine("You lost, word was: " + input);
                                        }
                                        break;

                                    case "single":
                                        Random word = new Random();
                                        int index = word.Next(englishWords.Length);
                                        Console.Clear();
                                        string inputMulti = englishWords[index];
                                        string copyInputMulti = inputMulti;
                                        int livesMulti = 10;
                                        string wrongMulti = "";
                                        do
                                        {
                                            string trueFalse = "";
                                            Console.Clear();
                                            Console.WriteLine("Lives: " + livesMulti);
                                            for (int i = 0; i < inputMulti.Length; i++)
                                            {
                                                if (copyInputMulti.Contains(inputMulti[i]))
                                                {
                                                    Console.Write("_ ");
                                                }
                                                else
                                                {
                                                    Console.Write(inputMulti[i] + " ");
                                                }
                                            }
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine("Wrong attempts was: " + wrongMulti);
                                            Console.Write("Enter a letter: ");

                                            char findCharMulti = Console.ReadKey().KeyChar;
                                            char[] inputArrayMulti = inputMulti.ToCharArray();
                                            foreach (char c in inputArrayMulti)
                                            {
                                                if (findCharMulti == c)
                                                {
                                                    trueFalse = "true";
                                                    copyInputMulti = copyInputMulti.Replace(c.ToString(), "");
                                                }
                                            }
                                            if (trueFalse != "true")
                                            {
                                                livesMulti--;
                                                wrongMulti += findCharMulti + ", ";
                                            }

                                        } while (livesMulti > 0 && copyInputMulti != "");
                                        Console.Clear();
                                        if (livesMulti > 0)
                                        {
                                            Console.WriteLine("You won, word was: " + inputMulti);
                                        }
                                        else
                                        {
                                            Console.WriteLine("You lost, word was: " + inputMulti);
                                        }
                                        break;

                                }
                                break;
                            case "exit":
                                return;
                        }
                    }
            }
        }
    }
}
