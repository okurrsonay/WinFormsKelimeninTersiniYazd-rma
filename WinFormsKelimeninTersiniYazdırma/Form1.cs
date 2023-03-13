namespace WinFormsKelimeninTersiniYazdırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string kelime = textBox1.Text;
            string kelime_ters="";

            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                kelime_ters += kelime[i];
            }
           
            if (kelime_ters == kelime)
            {
                MessageBox.Show(kelime+" Palindromik bir kelimedir.");
            }
            else
            {
                MessageBox.Show(kelime + " Palindromik bir kelime değildir.");
            }
        }
    }
}