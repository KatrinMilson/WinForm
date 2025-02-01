using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace PM01
{
    public partial class Form1 : Form
    {
        private PopupNotifier popup = null;
        private PopupNotifier popup1 = null;
        private PopupNotifier popup2 = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            popup = new PopupNotifier();
            popup.Image = Properties.Resources.shool;
            popup.ImageSize = new Size(100, 100);
            popup.TitleText = "PM01";
            popup.ContentText = "��������� ����������!";
            popup.TitleColor = Color.Aqua;
            popup.HeaderColor = Color.Blue;
            popup.BodyColor = Color.LightBlue;
            popup.ShowCloseButton = false;
            popup.TitleText = "������ ���������";
            popup.ContentText = "��� ������ ���������";

            popup1 = new PopupNotifier();
            popup1.Image = Properties.Resources.shool1;
            popup1.ImageSize = new Size(100, 100);
            popup1.TitleText = "PM01";
            popup1.ContentText = "��������� ����������!";
            popup1.TitleColor = Color.DarkRed;
            popup1.HeaderColor = Color.Red;
            popup1.BodyColor = Color.LightGray;
            popup1.ShowCloseButton = false;
            popup1.TitleText = "������ ���������";
            popup1.ContentText = "��� ������ ��������� �� �����!";

            popup2 = new PopupNotifier();
            popup2.Image = Properties.Resources.shool2;
            popup2.ImageSize = new Size(100, 100);
            popup2.TitleText = "PM01";
            popup2.ContentText = "��������� 3 ����������!";
            popup2.TitleColor = Color.DarkOliveGreen;
            popup2.HeaderColor = Color.DarkMagenta;
            popup2.BodyColor = Color.LightSalmon;
            popup2.ShowCloseButton = false;
            popup2.TitleText = "������ ���������";
            popup2.ContentText = "��� ������ ������ ���������!";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            popup.Popup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                popup1.Popup();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            popup2.Popup();
        }
    }
}