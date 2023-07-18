
//Alvaro Final project
//Save and loads the assingments in a txt file

using System;
using System.IO;

public class AskFileSave
{
  public AskFileSave()
  {

  }

  public List<List<string>> AskToLoad()
  {
    List<List<string>> SpamLines = new List<List<string>>();
    string AskFileSave = "AssingmentsToday.txt";
    string[] SpamLinesArray = System.IO.File.ReadAllLines(AskFileSave);

    // converts array into a list
    foreach (string SpamLineArray in SpamLinesArray)
    {
      List<string> SpamParts = new List<string>();
      string[] SpamPartsArray = SpamLineArray.Split("|");

      // splits the line into seperate parts then saves it into a list
      foreach (string SpamPartArray in SpamPartsArray)
      {
        SpamParts.Add(SpamPartArray);
      }
      
      // adds the part list to the lines list
      SpamLines.Add(SpamParts);
    }
    return SpamLines;
  }

  public void AskSave(List<string> DListAssi)
  {
    // reads the text document and converts it into a list
    string AskFileSave = "Assingment.txt";
    string[] SpamLinesArray = System.IO.File.ReadAllLines(AskFileSave);
    List<string> SpamLines = new List<string>();
    foreach (string SpamLineArray in SpamLinesArray)
    {
      SpamLines.Add(SpamLineArray);
    }

    // adds on to the previously made goals
    foreach (string Dassingment in DListAssi)
    {
      SpamLines.Add(Dassingment);
    }

// clears the text document
    TextWriter SpamClear = new StreamWriter(AskFileSave, false);
    SpamClear.Write(string.Empty);
    SpamClear.Close();

// writes the goals on the txt document
    using (StreamWriter SpamOutputFile = new StreamWriter(AskFileSave))
    {
      foreach (string SpamLine in SpamLines)
      {
        SpamOutputFile.WriteLine($"{SpamLine}");
      }
    }
  }
}