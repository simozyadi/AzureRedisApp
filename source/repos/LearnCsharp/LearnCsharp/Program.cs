namespace LearnCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();//publisher
            var mailservice = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailservice.OnVideoEncoded;
 
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.encode(video);

        }
    }
}
