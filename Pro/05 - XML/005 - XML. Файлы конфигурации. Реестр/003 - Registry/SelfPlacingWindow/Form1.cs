using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SelfPlacingWindow
{
	public partial class Form1 : Form
	{
		private System.Windows.Forms.ListBox listBoxMessages;
		private System.Windows.Forms.Button buttonChooseColor;
		private ColorDialog chooseColorDialog = new ColorDialog();

		public Form1()
		{
			InitializeComponent();

			buttonChooseColor.Click += new EventHandler(OnClickChooseColor);

			try
			{
				if (ReadSettings() == false)
					listBoxMessages.Items.Add("В реестре нет информации...");
				else
					listBoxMessages.Items.Add("Информация успешно загружена из реестра...");

				StartPosition = FormStartPosition.Manual;
			}
			catch (Exception e)
			{
				listBoxMessages.Items.Add("Возникала проблема при загрузке данных из реестра:");
				listBoxMessages.Items.Add(e.Message);
			}
		}

		void OnClickChooseColor(object Sender, EventArgs e)
		{
			if (chooseColorDialog.ShowDialog() == DialogResult.OK)
				BackColor = chooseColorDialog.Color;
		}

		void SaveSettings()
		{
			RegistryKey softwareKey = Registry.LocalMachine.OpenSubKey("Software", true);
			RegistryKey wroxKey = softwareKey.CreateSubKey("WroxPress");
			RegistryKey selfPlacingWindowKey = wroxKey.CreateSubKey("SelfPlacingWindow");

			selfPlacingWindowKey.SetValue("BackColor", (object)BackColor.ToKnownColor());
			selfPlacingWindowKey.SetValue("Red", (object)(int)BackColor.R);
			selfPlacingWindowKey.SetValue("Green", (object)(int)BackColor.G);
			selfPlacingWindowKey.SetValue("Blue", (object)(int)BackColor.B);
			selfPlacingWindowKey.SetValue("Width", (object)Width);
			selfPlacingWindowKey.SetValue("Height", (object)Height);
			selfPlacingWindowKey.SetValue("X", (object)DesktopLocation.X);
			selfPlacingWindowKey.SetValue("Y", (object)DesktopLocation.Y);
			selfPlacingWindowKey.SetValue("WindowState", (object)WindowState.ToString());
		}

		bool ReadSettings()
		{
			RegistryKey softwareKey = Registry.LocalMachine.OpenSubKey("Software");
			RegistryKey wroxKey = softwareKey.OpenSubKey("WroxPress");

			if (wroxKey == null)
				return false;

			RegistryKey selfPlacingWindowKey = wroxKey.OpenSubKey("SelfPlacingWindow");

			if (selfPlacingWindowKey == null)
				return false;
			else
				listBoxMessages.Items.Add("Успешно открыт ключ " + selfPlacingWindowKey.ToString());

			int redComponent = (int)selfPlacingWindowKey.GetValue("Red");
			int greenComponent = (int)selfPlacingWindowKey.GetValue("Green");
			int blueComponent = (int)selfPlacingWindowKey.GetValue("Blue");
			this.BackColor = Color.FromArgb(redComponent, greenComponent, blueComponent);
			listBoxMessages.Items.Add("Цвет фона: " + BackColor.Name);
			int X = (int)selfPlacingWindowKey.GetValue("X");
			int Y = (int)selfPlacingWindowKey.GetValue("Y");
			this.DesktopLocation = new Point(X, Y);
			listBoxMessages.Items.Add("Расположение: " + DesktopLocation.ToString());
			this.Height = (int)selfPlacingWindowKey.GetValue("Height");
			this.Width = (int)selfPlacingWindowKey.GetValue("Width");
			listBoxMessages.Items.Add("Размер: " + new Size(Width, Height).ToString());
			string initialWindowState = (string)selfPlacingWindowKey.GetValue("WindowState");
			listBoxMessages.Items.Add("Состояние окна: " + initialWindowState);
			this.WindowState = (FormWindowState)FormWindowState.Parse(WindowState.GetType(), initialWindowState);
			return true;
		}
	}
}
