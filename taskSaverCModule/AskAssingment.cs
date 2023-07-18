
//Final project Alvaro Nunez
//Save data from the AskToDo class
public abstract class AskAssingment
{
  protected String AskNameAssi;
  protected bool _spamIsComplete;

  public AskAssingment(String _AskNameAssi)
  {
    AskNameAssi = _AskNameAssi;
    _spamIsComplete = false;
  }

  public abstract String SpamToString();

  public bool SpamGetIsComplete()
  {
    return _spamIsComplete;
  }

  public abstract String AskSaveStringsLine();
}