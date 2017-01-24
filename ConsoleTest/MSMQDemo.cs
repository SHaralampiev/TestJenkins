using System.IO;
using System.Messaging;

namespace ConsoleTest
{
    internal class MSMQDemo
    {
        public MSMQDemo()
        {
            MessageQueue messageQueue = null;
            if (MessageQueue.Exists(@".\Private$\SomeTestName"))
            {
                messageQueue = new MessageQueue(@".\Private$\SomeTestName") { Label = "Testing Queue" };
            }
            else
            {
                // Create the Queue
                MessageQueue.Create(@".\Private$\SomeTestName");
                messageQueue = new MessageQueue(@".\Private$\SomeTestName") { Label = "Newly Created Queue" };
            }
            messageQueue.Send("First ever Message is sent to MSMQ", "Title");
        }


        public void ProcessMsgs()
        {
            var messageQueue = new MessageQueue(@".\Private$\SomeTestName");


            var messages = messageQueue.GetAllMessages();

            foreach (var message in messages)
            {
                message.Formatter = new ActiveXMessageFormatter();
                var reader = new StreamReader(message.BodyStream);

                var msgBody = reader.ReadToEnd();

                //Do something with the message.
            }
            // after all processing, delete all the messages
            messageQueue.Purge();
        }
    }
}
