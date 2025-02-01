namespace WinFormsApp5
{
    using System.Windows.Forms;
    using System.Drawing;

    class MyForm : Form
    {
        // ������� ������� ListBox ��� ���� ������: 
        // ��� �������� ���������� � ���� �� ������ ������� 
        ListBox listBox1;
        // �����-����������� ������ ������ 
        public MyForm()
        {
            //������� ����� 
            this.Size = new Size(400, 400);
            // �������� ������� PictureBox, �������� � ���� �����������, 
            // ������� ��� �� ����� 
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap image1 = new Bitmap("C:\\Users\\satoa\\OneDrive\\������� ����\\maxresdefault.jpg");
            pictureBox1.ClientSize = new Size(this.Width, 150);
            pictureBox1.Image = (Image)image1; this.Controls.Add(pictureBox1);
            // ������� ������ Button, ���������� ��������� �� ��� �������
            Button button1 = new System.Windows.Forms.Button();
            button1.Location = new Point(150, 160);
            button1.Size = new Size(100, 30);
            button1.Text = "����� ����";
            button1.Click += new System.EventHandler(button1_Click);
            this.Controls.Add(button1);
            // ������� ListBox, ���������� �������� � ��������� �� �����
            listBox1 = new System.Windows.Forms.ListBox();
            listBox1.Location = new System.Drawing.Point(20, 200);
            listBox1.Size = new Size(100, 100); listBox1.Items.Add("���");
            listBox1.Items.Add("����� ");
            listBox1.Items.Add("�����");
            listBox1.Items.Add("����");
            listBox1.Items.Add("�����");
            listBox1.SelectedIndex = 2;
            this.Controls.Add(listBox1);
        }
        // ���������� �������, ������������� ��� ������� ������ 
        void button1_Click(object sender, System.EventArgs e)
        {
            // ������� ��������� � ��������� ���������� � ������ ������
            MessageBox.Show(this, "�� ������� " + listBox1.SelectedItem, "�����������", MessageBoxButtons.OK);
        }
        static void Main()
        {
            // ������� � ��������� ����� 
            Application.Run(new MyForm());
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyForm 
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "MyForm"; this.ResumeLayout(false);
        }
    }
}