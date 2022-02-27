using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practice.EventTopic
{
    class Subscriber
    {
        static void Main()
        {
            VideoEncoder videoEncoder = new VideoEncoder();

            videoEncoder.VideoEncodedEvent += new MailService().SendMail; //Subscribe
            videoEncoder.VideoEncodedEvent += new MessageService().SendMessage; //Subscribe

            videoEncoder.Encoder(new Video { Title = "==> [My First YouTube Adventure Vlog......]" }); //Raise an Event

            Console.ReadLine();
        }
    }

    class MailService
    {
        public void SendMail(object source, VideoEncodeEventArgs args)
        {
            Console.WriteLine("Mail Service sending mail...... Video Title" + args.Video.Title);
        }
    }

    class MessageService
    {
        public void SendMessage(object source, VideoEncodeEventArgs args)
        {
            Console.WriteLine("Message Service sending message......Video Title" + args.Video.Title);
        }
    }


}
