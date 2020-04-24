namespace EventQuetes
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new MessageLogger();            
            var sender = new StandardOutputLogger();
            var file = new FileStreamOutputLogger();
            
            logger.SendLog += sender.OnSendLog;
            logger.SendLog += file.OnSendLog;

            logger.Write("cucu everybody");
        }
    }
}
