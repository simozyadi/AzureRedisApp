using System;

namespace LearnCsharp
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending Email .."+args.Video.Title);

        }

    }
}
