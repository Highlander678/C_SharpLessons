using System;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Windows.Forms;

namespace AdditionTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.SafeFileName;
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {

            var adSetup = new AppDomainSetup { ApplicationBase = Path.GetFullPath(Application.ExecutablePath) };

            // Настраиваем права для  AppDomain. Даем разрешение на выполнение кода.
            // Список прав : http://msdn.microsoft.com/ru-ru/library/24ed02w7.aspx
            var permSet = new PermissionSet(PermissionState.None);
            permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            permSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.AllAccess, "c:\\"));
            permSet.AddPermission(new UIPermission(UIPermissionWindow.AllWindows, UIPermissionClipboard.AllClipboard));

            var fullTrustAssembly = typeof(Form1).Assembly.Evidence.GetHostEvidence<StrongName>();

            var newDomain = AppDomain.CreateDomain("Sandbox", null, adSetup, permSet, fullTrustAssembly);

            newDomain.ExecuteAssembly(openFileDialog1.FileName);

        }
    }
}
