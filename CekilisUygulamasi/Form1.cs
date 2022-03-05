namespace CekilisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int liste_sayi = listBox1.Items.Count+1;
            int[] isimler = new int[liste_sayi];
            Random rnd = new Random();
            int i = 0;
            while (i < 3)
            {
                int secim = rnd.Next(liste_sayi);
                if (Array.IndexOf(isimler,secim)==-1)
                {
                    isimler[i] = secim;
                    label1.Text += listBox1.Items[secim-1] + "\n";
                    i++;

                }
                
            }
        }
    }
}