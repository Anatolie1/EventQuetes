using System;

namespace EventQuetes
{
    public class StandardOutputLogger
    {
        public void OnSendLog(object source, SendLogEventArgs args)
        {
            Console.WriteLine(args.Message+"\t\t"+args.Time);
        }
    }
}
