
//final Project Alvaro
//Add new asssingment class

public class AskToDo : AskAssingment
{
  public AskToDo(string AskNameAssi) : base( AskNameAssi)
  {

  }

  public override string SpamToString()
  {
    if (base.SpamGetIsComplete() == true)
    {
      return $"[X] {base.AskNameAssi}";
    }

    else
    {
      return $"[] {base.AskNameAssi}";
    }
  }

  public override string AskSaveStringsLine()
  {
    return $"{AskNameAssi}|To Do";
  }
}
