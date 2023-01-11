namespace WinFormsAppLoginExample
{
    public partial class Form1 : Form
    {
        private string userName = "admin";
        private string password = "1234";
        TextBox textBoxUserName;
        TextBox textBoxPassword;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxUserName = new TextBox();
            textBoxUserName.Left = (this.ClientSize.Width - textBoxUserName.Width) / 2;
            textBoxUserName.Top = this.ClientSize.Height / 6;
            this.Controls.Add(textBoxUserName);

            textBoxPassword = new TextBox();
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Left = (this.ClientSize.Width - textBoxPassword.Width) / 2;
            textBoxPassword.Top = this.ClientSize.Height / 4;
            this.Controls.Add(textBoxPassword);

            Button button1 = new Button();
            button1.Width = 200;
            button1.Height = 100;
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button1.Top = (this.ClientSize.Height - button1.Height) / 2;
            button1.Text = "Login";
            button1.Click += button1_Click;
            this.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxUserName.Text == userName && this.textBoxPassword.Text == password)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }
    }
}