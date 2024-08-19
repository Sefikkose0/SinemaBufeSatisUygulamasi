namespace SinemaBufeSatisUygulamasi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int kasatutar = 0;
		private void button1_Click(object sender, EventArgs e)
		{
			int Misir, Bilet, Su, Cay, Toplam;
			Misir = Convert.ToInt16(txtMisir.Text);
			Bilet = Convert.ToInt16(txtBilet.Text);
			Su = Convert.ToInt16(txtSu.Text);
			Cay = Convert.ToInt16(txtCay.Text);
			Toplam = (Misir * 4) + (Cay * 2) + (Su * 1) + (Bilet * 8);
			LblToplam.Text = Toplam.ToString() + "TL";
			kasatutar = kasatutar + Toplam;
			LblKasa.Text = kasatutar.ToString() + "TL";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txtMisir.Text = "";
			txtBilet.Text = "";
			txtCay.Text = "";
			txtSu.Text = "";
			txtMisir.Focus();
		}
	}
}
