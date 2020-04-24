using System.IO;

namespace EventQuetes
{
    public class FileStreamOutputLogger
    { 
        public void OnSendLog(object source, SendLogEventArgs args)
        {
            CreateFile($"{args.Message}\t\t{args.Time}");
        }

        public void CreateFile(string message)
        {
            string filepath = @"E:\C#\Refelection\EventQuetes\" + "MessageFile.txt";

            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }

            File.Create(filepath).Close();

            TextWriter tw = new StreamWriter(filepath, true);
            tw.WriteLine(message);
            tw.Close();
        }
    }
}
