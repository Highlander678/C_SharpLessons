using System;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace APM
{
    class AsyncResult : IAsyncResult, IMessageSink
    {
        IMessage message;

        WaitCallback asyncTask; // Fibonacci
        AsyncCallback asyncCallback; // Callback Method

        object asyncState;
        ManualResetEvent waitHandle;
        bool isCompleted;

        public bool isInvokeAsyncCallback;

        #region Реализация IAsyncResult

        public object AsyncState
        {
            get { return asyncState; }
        }

        public bool CompletedSynchronously
        {
            // AsyncResult - участвует только в асинхронной обработке,
            // поэтому всегда возвращается - false.
            get { return false; }
        }

        public WaitHandle AsyncWaitHandle
        {
            get { return waitHandle; }
        }

        public bool IsCompleted
        {
            get { return isCompleted; }
        }

        #endregion

        #region Реализация IMessageSink

        public IMessageSink NextSink
        {
            get { return null; }
        }

        public IMessage SyncProcessMessage(IMessage message)
        {
            this.message = message;
            asyncTask = (WaitCallback)message.Properties["asyncTask"];
            asyncCallback = (AsyncCallback)message.Properties["asyncCallback"];
            asyncState = message.Properties["asyncState"];

            waitHandle = new ManualResetEvent(false);

            ThreadPool.QueueUserWorkItem(AsyncTask, this); 

            return message;
        }

        public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
        {
            throw new NotSupportedException("NotSupported_Method");
        }

        #endregion

        void AsyncTask(object asyncResult)
        {
            if (asyncTask != null)
            {
                asyncTask.Invoke(null);
            }

            if (asyncCallback != null)
            {
                isInvokeAsyncCallback = true;
                asyncCallback.Invoke(this);
            }
           
            waitHandle.Set();
            isCompleted = true;
        }

        public virtual IMessage GetReplyMessage()
        {
            return message;
        }

        public virtual object AsyncDelegate
        {
            get { return asyncTask; }
        }
    }
}