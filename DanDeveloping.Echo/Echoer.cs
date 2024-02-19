namespace Echo
{
  public class Echoer
  {
    private string _Message = string.Empty;

    public string Echo(string message)
    {
      _Message = message ?? string.Empty;
      string retVal = GenerateEcho();
      return retVal;

    }

    private string GenerateEcho()
    {
      var retVal = string.Empty;
      var messageNeedsCutting = _Message.Length > 15;
      if (messageNeedsCutting)
      {

#if NETSTANDARD2_0_OR_GREATER
        retVal = _Message.Substring(_Message.Length - 15);
#elif NET47_OR_GREATER
        retVal = _Message.Substring(_Message.Length - 15);
#elif NET8_0_OR_GREATER
        var cutLength = 15;
        retVal = _Message[^cutLength..];
#elif NET6_0_OR_GREATER
        retVal = _Message[^15..];
#endif
      }
      else
      {
        retVal = _Message;
      }

      return retVal;
    }
  }
}
