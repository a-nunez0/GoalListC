
//Alvaro Nunez Final project
//Just the menu

using System;
public class AskMenu
{

  public AskMenu()
  {

  }

  public void AskMenuSelection()
  {
    Console.WriteLine("Hey! Welcome back!");
    Console.WriteLine("Please choose one of the following to continue");
    Console.WriteLine("1). Add To List");
    Console.WriteLine("2). Check List");
    Console.WriteLine("3). Assingment Completed");
    Console.WriteLine("3). Quit");
  }

  public string AskQ()
  {
    Console.Write("Please enter the numberical value of the preferred activity: ");
    return Console.ReadLine();
  }
}