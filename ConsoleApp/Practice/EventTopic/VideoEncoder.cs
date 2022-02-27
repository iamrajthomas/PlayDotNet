using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.Practice.EventTopic
{
    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEncodeEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //define a delegate
        //define an event with the same delegate
        //raise an event

        //public delegate void VideoEncodedDelegate(object source, VideoEncodeEventArgs args); //delegate
        //public event VideoEncodedDelegate VideoEncodedEvent; //event

        public EventHandler<VideoEncodeEventArgs> VideoEncodedEvent; //delegate + event

        public void Encoder(Video video)
        {
            Console.WriteLine("Video Encoding...........");
            Thread.Sleep(4000);

            VideoEncodedEventHandler(video);
        }

        protected virtual void VideoEncodedEventHandler(Video video)
        {
            if (VideoEncodedEvent != null)
                VideoEncodedEvent(this, new VideoEncodeEventArgs { Video = video });
        }
    }
}
