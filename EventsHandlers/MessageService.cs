using System;

namespace EventsHandlers
{
    public class MessageService
    {
        // event handler
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a message..." + args.Video.Title);
        }
    }
}
