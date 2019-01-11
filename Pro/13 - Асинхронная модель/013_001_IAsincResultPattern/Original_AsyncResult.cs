// ==++== 
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--== 
/*============================================================
** 
** Interface: AsyncResult 
**
** Purpose: Object to encapsulate the results of an async 
**          operation
**
===========================================================*/

using System.Threading;
using System.Runtime.Remoting;
using System;
using System.Security.Permissions;
using System.Runtime.Remoting.Messaging;

namespace APM //namespace System.Runtime.Remoting.Messaging
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public class Original_AsyncResult : IAsyncResult, IMessageSink
    {
        IMessageCtrl _mc;
        AsyncCallback _acbd;
        IMessage _replyMsg;
        bool _isCompleted;
        bool _endInvokeCalled;
        ManualResetEvent _AsyncWaitHandle;
        Delegate _asyncDelegate;
        Object _asyncState;

        [System.Security.SecurityCritical]  // auto-generated
        internal Original_AsyncResult(Message m)
        {
            //m.GetAsyncBeginInfo(out _acbd, out _asyncState);
            //_asyncDelegate = (Delegate)m.GetThisPtr();
        }

        // True if the asynchronous operation has been completed. 
        public virtual bool IsCompleted
        {
            get { return _isCompleted; }
        }

        // The delegate object on which the async call was invoked.
        public virtual Object AsyncDelegate
        {
            get { return _asyncDelegate; }
        }

        // The state object passed in via BeginInvoke. 
        public virtual Object AsyncState
        {
            get { return _asyncState; }
        }

        public virtual bool CompletedSynchronously
        {
            get { return false; }
        }

        public bool EndInvokeCalled
        {
            get { return _endInvokeCalled; }
            set
            {
                //BCLDebug.Assert(!_endInvokeCalled && value, "EndInvoke prevents multiple calls");
                _endInvokeCalled = value;
            }
        }

        private void FaultInWaitHandle()
        {
            lock (this)
            {
                if (_AsyncWaitHandle == null)
                    _AsyncWaitHandle = new ManualResetEvent(false);
            }
        }

        public virtual WaitHandle AsyncWaitHandle
        {
            get
            {
                FaultInWaitHandle();
                return _AsyncWaitHandle;
            }
        }

        public virtual void SetMessageCtrl(IMessageCtrl mc)
        {
            _mc = mc;
        }

        [System.Security.SecurityCritical]  // auto-generated_required 
        public virtual IMessage SyncProcessMessage(IMessage msg)
        {
            if (msg == null)
            {
                //_replyMsg = new ReturnMessage(new RemotingException(Environment.GetResourceString("Remoting_NullMessage")), new ErrorMessage());
            }
            else if (!(msg is IMethodReturnMessage))
            {
                //_replyMsg = new ReturnMessage(new RemotingException(Environment.GetResourceString("Remoting_Message_BadType")), new ErrorMessage());
            }
            else
            {
                _replyMsg = msg;
            }

            _isCompleted = true;
            FaultInWaitHandle();

            _AsyncWaitHandle.Set();
            if (_acbd != null)
            {
                // NOTE: We are invoking user code here!
                // Catch and Ignore exceptions thrown from async callback user code.
                _acbd(this);
            }
            return null;
        }

        [System.Security.SecurityCritical]  // auto-generated_required 
        public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
        {
            throw new NotSupportedException("NotSupported_Method");
        }

        public IMessageSink NextSink
        {
            [System.Security.SecurityCritical]  // auto-generated_required 
            get
            { return null; }
        }

        public virtual IMessage GetReplyMessage() { return _replyMsg; }
    }
}

// File provided for Reference Use Only by Microsoft Corporation (c) 2007.
