using System;

namespace LearnCsharp
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending Email .."+args.Video.Title);

        }
    }
}
