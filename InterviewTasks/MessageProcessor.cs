using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTasks
{
    // Task: change MessageProcessor's methods so that make the calss thread-safe.
    // Context: IMessageHandler.HandleMessage() is thread-safe.
    // Restrictions: Do not change methods signature.

    public class Message
    {
        public string Text { get; set; }
    }

    public interface IMessageHandler
    {
        void HandleMessage(Message e);
    }

    public class MessageProcessor
    {
        private ConcurrentBag<IMessageHandler> _handlers; // change list to concurentBag

        public MessageProcessor(List<IMessageHandler> handlers)
        {
            _handlers = new ConcurrentBag<IMessageHandler>(handlers);
        } 

        // Parallel
        public void ProcessMessage(Message msg)
        {
            Parallel.ForEach<IMessageHandler>(_handlers, handler => handler.HandleMessage(msg));

            //foreach (var handler in _handlers)
            //{
            //    handler.HandleMessage(msg);
            //}
        }

        public void AddHandler(IMessageHandler handler)
        {
            _handlers.Add(handler);
        }

        public void RemoveHandler(IMessageHandler handler)
        {
            _handlers.TryTake(out handler);
        }   
    }
}