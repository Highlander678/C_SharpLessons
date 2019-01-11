using System.ComponentModel;

namespace WindowsServices
{
    partial class MyService
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // 
            // MyService
            // 
            components = new Container();
            this.ServiceName = "===== TEST SERVICE =====";

        }
    }
}
