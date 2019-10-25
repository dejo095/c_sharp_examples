using System;

namespace EventsHandlers
{
    // subscriber
    public class MailService
    {
        // event handler
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mailservice: Sending an email..." + e.Video.Title);
        }
    }
}
