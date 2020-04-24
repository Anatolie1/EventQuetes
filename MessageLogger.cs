using System;

namespace EventQuetes
{
    public class MessageLogger
    {
        public event EventHandler<SendLogEventArgs> SendLog;

        public void Write(string message)
        {
            OnSendLog(message);
        }

        protected virtual void OnSendLog(string message)
        {
            if (SendLog != null)
            {
                SendLog(this, new SendLogEventArgs() { Message = message, Time = DateTime.Now});
            }
        }
    }
}
