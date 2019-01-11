using System;
using System.Runtime.Remoting.Messaging;
using System.Collections;
using System.Threading;

namespace APM
{
    class Message : IMessage
    {
        IDictionary dictionary;

        // Конструктор
        public Message(WaitCallback asyncTask,
                       AsyncCallback asyncCallback,
                       object asyncState)
        {
            dictionary = new Hashtable();
            dictionary.Add("asyncTask", asyncTask);
            dictionary.Add("asyncCallback", asyncCallback);
            dictionary.Add("asyncState", asyncState);
        }

        public IDictionary Properties
        {
            get { return dictionary; }
        }
    }
}
