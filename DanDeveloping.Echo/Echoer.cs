namespace Echo
{
  /// <summary>
  /// This class is designed to return an echo of a message.
  /// </summary>
  public class Echoer
  {
    private string _Message = string.Empty;

    /// <summary>
    /// Main execution method for this class.
    /// This method will reduce the message provided.  If longer than 15 characters, will limit to last 15 characters.
    /// </summary>
    /// <param name="message">Message to be returned as an echo.</param>
    /// <returns></returns>
    public string Echo(string message)
    {
      _Message = message ?? string.Empty;
      string retVal = GenerateEcho();
      return retVal;

    }

    private string GenerateEcho()
    {
      string retVal;
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
