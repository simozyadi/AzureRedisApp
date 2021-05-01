using System;
using System.Threading;

namespace LearnCsharp
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    internal class VideoEncoder
    {
        // 1- define a delegate
        // 2- define an event based on that delegate
        // 3- raise the evnet
        //public delegate void VideoEncodedHandeler(object source, VideoEventArgs args);
        // public event VideoEncodedHandeler VideoEncoded;

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video});

        }

    }
}