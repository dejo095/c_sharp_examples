namespace EventsHandlers
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Terminator" };

            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber


            // lets subscribe
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

        }
    }
}
