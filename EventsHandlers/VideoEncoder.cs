using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsHandlers
{

    public class VideoEncoder
    {
        // 1- define delegate
        // 2- define an event based on delegate
        // 3- raise an event

        // delegate
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // event
        //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;

        

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video..");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // raise an event
        protected virtual void OnVideoEncoded(Video video)
        {
            // notify all subscribers if there are any
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video =  video});
        }
    }
}
