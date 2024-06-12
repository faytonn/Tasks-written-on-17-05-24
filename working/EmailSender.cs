namespace working
{
    public class EmailSender : MessageSender
    {
       
        public override void SendMessage(string message)
        {
            Console.WriteLine("Send email:" + message);
        }

    }
}
