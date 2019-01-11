using System.Windows.Media;

namespace Task_3
{
    interface ISetting
    {
        Brush BackColor { get; set; }
        Brush TextColor { get; set; }
        int TextSize { get; set; }
        FontFamily TextFont { get; set; }

        void SaveSettings();
    }
}
