using System.Reflection;

namespace OdemeOrnek
{
    public partial class Form1 : Form
    {
        string secilenOdemeTipi = "";


        public Form1()
        {
            
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(textBox1.Text);


            IOdemeTipi iodemeTipi;
            OdemeIslemiFactor factor= new OdemeIslemiFactor();
            iodemeTipi = factor.GetInstance(secilenOdemeTipi);
            OdemeIslemi odemeIslemi = new OdemeIslemi(iodemeTipi);
            string result = odemeIslemi.Ode(tutar);


            MessageBox.Show(result);

        }

        public void cmbOdemeYontemi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenOdemeTipi = cmbOdemeYontemi.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}