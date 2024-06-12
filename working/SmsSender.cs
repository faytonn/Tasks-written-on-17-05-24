namespace working
{
    public class SmsSender : MessageSender
    {
        public override void SendMessage(string message)
        {
            Console.WriteLine("Send SMS" + message);
        }
    }
}
