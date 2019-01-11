using System;
using System.Xml;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace SelfPlacingWindow
{
	public partial class Form1 : Form
	{
		private ListBox listBox1;
		private Button buttonChooseColor;
		private ColorDialog chooseColorDialog = new ColorDialog();

		public Form1()
		{
			InitializeComponent();

			buttonChooseColor.Click += new EventHandler(OnClickChooseColor);

			try
			{
				if (ReadSettings() == false)
					listBox1.Items.Add("В файле конфигурации нет информации...");
				else
					listBox1.Items.Add("Информация успешно загружена из файла конфигурации...");

				this.StartPosition = FormStartPosition.CenterScreen;
			}
			catch (Exception e)
			{
				listBox1.Items.Add("Возникала проблема при загрузке данных из файла конфигурации:");
				listBox1.Items.Add(e.Message);
			}
		}

		void OnClickChooseColor(object Sender, EventArgs e)
		{
			if (chooseColorDialog.ShowDialog() == DialogResult.OK)
				this.BackColor = chooseColorDialog.Color;
		}

		// Сохранение текущего состояния.
		void SaveSettings()
		{
			// Сохранение происходит при помощи работы с XML.
			XmlDocument doc = loadConfigDocument();

			// Открываем узел appSettings, в котором содержится перечень настроек.
			XmlNode node = doc.SelectSingleNode("//appSettings");

			// Массив ключей (создан для упрощения обращения к файлу конфигурации).
			string[] keys = new string[] {"BackGroundColor.R",
										  "BackGroundColor.G",
										  "BackGroundColor.B",
										  "X",
										  "Y",
										  "Window.Height",
										  "Window.Width",
										  "Window.State"};

			// Массив значений (создан для упрощения обращения к файлу конфигурации).
			string[] values = new string[] { BackColor.R.ToString(),
											 BackColor.G.ToString(),
											 BackColor.B.ToString(),
											 DesktopLocation.X.ToString(),
											 DesktopLocation.Y.ToString(),
											 Height.ToString(),
											 Width.ToString(),
											 WindowState.ToString() };

			// Цикл модификации файла конфигурации.
			for (int i = 0; i < keys.Length; i++)
			{
				// Обращаемся к конкретной строке по ключу.
				XmlElement element = node.SelectSingleNode(string.Format("//add[@key='{0}']", keys[i])) as XmlElement;

				// Если строка с таким ключем существует - записываем значение.
				if (element != null) { element.SetAttribute("value", values[i]); }
				else
				{
					// Иначе: создаем строку и формируем в ней пару [ключ]-[значение].
					element = doc.CreateElement("add");
					element.SetAttribute("key", keys[i]);
					element.SetAttribute("value", values[i]);
					node.AppendChild(element);
				}
			}

			// Сохраняем результат модификации.
			doc.Save(Assembly.GetExecutingAssembly().Location + ".config");
		}

		// Восстановление данных из файла конфигурации.
		bool ReadSettings()
		{
			// Загрузка настроек по парам [ключ]-[значение].
			NameValueCollection allAppSettings = ConfigurationManager.AppSettings;
			if (allAppSettings.Count < 1) { return (false); }

			// Восстановление состояния:
			//1. Цвет фона.
			int red = Convert.ToInt32(allAppSettings["BackGroundColor.R"]);
			int green = Convert.ToInt32(allAppSettings["BackGroundColor.G"]);
			int blue = Convert.ToInt32(allAppSettings["BackGroundColor.B"]);

			this.BackColor = Color.FromArgb(red, green, blue);
			listBox1.Items.Add("Цвет фона: " + BackColor.Name);

			//2. Расположение на экране.
			int X = Convert.ToInt32(allAppSettings["X"]);
			int Y = Convert.ToInt32(allAppSettings["Y"]);

			this.DesktopLocation = new Point(X, Y);
			listBox1.Items.Add("Расположение: " + DesktopLocation.ToString());

			//3. Размеры окна.
			this.Height = Convert.ToInt32(allAppSettings["Window.Height"]);
			this.Width = Convert.ToInt32(allAppSettings["Window.Width"]);
			listBox1.Items.Add("Размер: " + new Size(Width, Height).ToString());

			//4. Состояние окна.
			string winState = allAppSettings["Window.State"];
			listBox1.Items.Add("Состояние окна: " + winState);
			this.WindowState = (FormWindowState)FormWindowState.Parse(WindowState.GetType(), winState);
			return (true);
		}

		/// <summary>
		/// Создает новый конфигурационный документ.
		/// </summary>
		/// <returns></returns>
		private static XmlDocument loadConfigDocument()
		{
			XmlDocument doc = null;
			try
			{
				doc = new XmlDocument();
				doc.Load(Assembly.GetExecutingAssembly().Location + ".config");
				return doc;
			}
			catch (System.IO.FileNotFoundException e)
			{
				throw new Exception("No configuration file found.", e);
			}
		}
	}
}
