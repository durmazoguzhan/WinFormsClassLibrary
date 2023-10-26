using ClassLibraryInveonOrnek;


namespace WinFormsReflectionClassLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = Matematik.Topla(numSayi1.Value, numSayi2.Value).ToString();
        }
    }
}