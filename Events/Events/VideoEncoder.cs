using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //custom event arguments
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    //video encoder
    public class VideoEncoder
    {
        //delegate of subscribers that should be notified after encoding (old way)
        // public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);

        //event handler for video encoding
        public event EventHandler<VideoEventArgs> VideoEncoded;


        //encode a video
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        //raise event
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }

    }
}
