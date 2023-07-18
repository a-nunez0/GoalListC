
//Alvaro Nunez
//Joins all the classes and uses all their functions.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<AskAssingment> AssToDo = new List<AskAssingment>();
        AskMenu Askmenu = new AskMenu();
        AskFileSave askFile = new AskFileSave();
        bool AskKeep = true;

        while (AskKeep)
        {
            Askmenu.AskMenuSelection();
            String AskChoice = Askmenu.AskQ();
            switch (AskChoice)
            {
                case "1":
                    //Create new Assi
                    String AskNameOf = "";
                    Console.Clear();
                    Console.WriteLine("What is athe assingment? ");

                    Console.Write(" ");
                    AskToDo AskAddTo = new AskToDo(AskNameOf);
                    AssToDo.Add(AskAddTo);

                    break;

                case "2":

                    Console.WriteLine("These are the assingments:");
                    int AskCounting = 1;
                    foreach (AskAssingment AGoal in AssToDo)
                    {
                        Console.WriteLine($"{AskCounting}. {AGoal.SpamToString()}");
                        AskCounting++;
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.Write("");
                    break;

                case "3":

                    Console.WriteLine("Saving assingment...");
                    List<String> spamGoalsAsStrings = new List<String>();

                    foreach (AskAssingment Assi in AssToDo)
                    {
                        spamGoalsAsStrings.Add(Assi.AskSaveStringsLine());
                    }

                    askFile.AskSave(spamGoalsAsStrings);

                    Console.WriteLine("Saved!");
                    Console.WriteLine("Press Enter to continue");
                    Console.Write("");

                    break;

                case "4":

                    AskKeep = false;
                    break;

                default:

                    Console.WriteLine("Please try a valid number.");

                    break;

            }
        }
        Console.Clear();
        Console.WriteLine("See ya later!");
    }
}
