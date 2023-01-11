namespace WinFormsAppLoginExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Label label = new Label();
            label.Text = "Giris Basarili!";
            label.Top = (this.ClientSize.Height - label.Height) / 2;
            label.Left = (this.ClientSize.Width - label.Width) / 2;
            this.Controls.Add(label);
        }
    }
}
