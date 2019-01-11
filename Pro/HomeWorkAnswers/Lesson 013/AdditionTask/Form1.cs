using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;

namespace AdditionTask
{
    public partial class Form1 : Form
    {
        SynchronizationContext sync;

        public Form1()
        {
            InitializeComponent();
        }

        Func<int, int, int> function;

        bool ArgsValidation(out int x, out int y)
        {
            bool xIsCorrect = Int32.TryParse(textBoxX.Text, out x);
            bool yIsCorrect = Int32.TryParse(textBoxY.Text, out y);
            if (!(xIsCorrect && yIsCorrect))
            {
                MessageBox.Show("Args invalid");
                return true;
            }
            return false;
        }

        public int Add(int x, int y)
        {
            Thread.Sleep(1000);
            return x + y;
        }

        public void CallBack(IAsyncResult asyncResult)
        {
            AsyncResult async = (AsyncResult)asyncResult;
            var delegateAdd = (Func<int, int, int>)async.AsyncDelegate;

            var result = delegateAdd.EndInvoke(asyncResult);

            sync.Post(delegate { textBoxResult.Text = result.ToString(); }, null);           
        }

        private void IsComplete_Click(object sender, EventArgs e)
        {
            int x, y;

            if (ArgsValidation(out x, out y))
            {
                return;
            }

            function = new Func<int, int, int>(Add);
            IAsyncResult func = function.BeginInvoke(x, y, null, null);
            while (!func.IsCompleted)
            {
                Thread.Sleep(100);
            }

            MessageBox.Show("IsCompleted");

            textBoxResult.Text = function.EndInvoke(func).ToString();
        }

        private void End_Click(object sender, EventArgs e)
        {
            int x, y;

            if (ArgsValidation(out x, out y))
            {
                return;
            }

            function = new Func<int, int, int>(Add);
            IAsyncResult func = function.BeginInvoke(x, y, null, null);

            textBoxResult.Text = function.EndInvoke(func).ToString();

            MessageBox.Show("EndInvoke");
        }

        private void Callback_Click(object sender, EventArgs e)
        {
            int x, y;

            if (ArgsValidation(out x, out y))
            {
                return;
            }

            function = new Func<int, int, int>(Add);

            sync = SynchronizationContext.Current;

            IAsyncResult func = function.BeginInvoke(x, y, CallBack, null);

            MessageBox.Show("CallBack");
        }
    }
}
