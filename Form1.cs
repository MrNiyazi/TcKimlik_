﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace TcKimlik
{
	public partial class Form1 : MetroFramework.Forms.MetroForm
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			long TCKN = long.Parse(textBox3.Text);
			string Ad, Soyad;
			Ad = textBox1.Text;
			Soyad = textBox2.Text;
			int DY = dateTimePicker1.Value.Year;
			KimlikBilgileriService.KPSPublicSoapClient KK = new
				KimlikBilgileriService.KPSPublicSoapClient();
            bool Durum = KK.TCKimlikNoDogrula(TCKN,Ad,Soyad,DY);
			if(Durum == true){
				MessageBox.Show("Girilen kimlik bilgileri doğrulandı","",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			if (Durum == false)
			{
				MessageBox.Show("Girilen kimlik bilgileri yanlıştır", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
	}
}
