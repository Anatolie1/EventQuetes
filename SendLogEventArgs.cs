using System;

namespace EventQuetes
{
    public class SendLogEventArgs : EventArgs
    {
        public string Message { get; set; }
        public DateTime Time { get; set; }
    }
}
