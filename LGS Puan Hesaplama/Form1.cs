using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LGS_Puan_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        double td = 0;
        double ty = 0;
        double tnet = 0;

        double inkd = 0;
        double inky = 0;
        double inknet = 0;

        double dd = 0;
        double dy = 0;
        double dnet = 0;


        double ingd = 0;
        double ingy = 0;
        double ingnet = 0;

        double md = 0;
        double my = 0;
        double mnet = 0;

        double fd = 0;
        double fy = 0;
        double fnet = 0;




        private void ButtonHESAPLA_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(textBoxTD.Text.ToString()))
            {
                td = Convert.ToDouble(textBoxTD.Text.ToString());
            }
            if (!string.IsNullOrEmpty(textBoxTY.Text.ToString()))
            {
                ty = Convert.ToDouble(textBoxTY.Text.ToString());
            }
            tnet = td - ty / 3;
            tnet=Math.Round(tnet, 4);
            textBoxTN.Text = tnet.ToString();

           
            if (!string.IsNullOrEmpty(textBoxİNKD.Text.ToString()))
            {
                inkd = Convert.ToDouble(textBoxİNKD.Text.ToString());
            }
            if (!string.IsNullOrEmpty(textBoxİNKY.Text.ToString()))
            {
                inky = Convert.ToDouble(textBoxİNKY.Text.ToString());
            }
            inknet = inkd - inky / 3;
            inknet=Math.Round(inknet, 4);
            textBoxİNKN.Text = inknet.ToString();

           
            if (!string.IsNullOrEmpty(textBoxDD.Text.ToString()))
            {
                dd = Convert.ToDouble(textBoxDD.Text.ToString());
            }
            if (!string.IsNullOrEmpty(textBoxDY.Text.ToString()))
            {
                dy = Convert.ToDouble(textBoxDY.Text.ToString());
            }
            dnet = dd - dy / 3;
            dnet= Math.Round(dnet,4);
            textBoxDN.Text = dnet.ToString();

           
            if (!string.IsNullOrEmpty(textBoxİNGD.Text.ToString()))
            {
                ingd = Convert.ToDouble(textBoxİNGD.Text.ToString());
            }
            if (!string.IsNullOrEmpty(textBoxİNGY.Text.ToString()))
            {
                ingy = Convert.ToDouble(textBoxİNGY.Text.ToString());
            }
            ingnet = ingd - ingy / 3;
            ingnet =Math.Round(ingnet, 4);
            textBoxINGN.Text = ingnet.ToString();

           
            if (!string.IsNullOrEmpty(textBoxMD.Text.ToString()))
            {
                md = Convert.ToDouble(textBoxMD.Text.ToString());
            }
            if (!string.IsNullOrEmpty(textBoxMY.Text.ToString()))
            {
                my = Convert.ToDouble(textBoxMY.Text.ToString());
            }
            mnet = md - my / 3;
            mnet= Math.Round(mnet, 4);
            textBoxMN.Text = mnet.ToString();

           
            if (!string.IsNullOrEmpty(textBoxFD.Text.ToString()))
            {
                fd = Convert.ToDouble(textBoxFD.Text.ToString());
            }
            if (!string.IsNullOrEmpty(textBoxFY.Text.ToString()))
            {
                fy = Convert.ToDouble(textBoxFY.Text.ToString());
            }
            fnet = fd - fy / 3;
            fnet=Math.Round(fnet, 4);
            textBoxFN.Text = fnet.ToString();

            double TASP = 4 * (10 * ((tnet - 11.75) / 5.15) + 50) +
                          1 * (10 * ((inknet - 6.88) / 2.82) + 50) +
                          1 * (10 * ((dnet - 6.83) / 2.41) + 50) +
                          1 * (10 * ((ingnet - 4.65) / 3.21) + 50) +
                          4 * (10 * ((mnet - 5.09) / 4.24) + 50) +
                          4 * (10 * ((fnet - 9.97) / 4.72) + 50);
        
            double puan = 193.487 + 3.6714 * tnet + 1.6813 * inknet + 1.9407 * dnet + 1.6367 * ingnet + 4.9526 * mnet + 4.0723 * fnet;

            puan = Math.Round(puan, 4);
            textBoxPUAN.Text = puan.ToString();

            textBoxPUAN.BackColor = textBoxPUAN.BackColor;                    
            textBoxPUAN.ForeColor = Color.Red;
            MessageBox.Show("Puanınız hesaplandı!\n\nAlınan puan: "+puan);
        }     

        private void TextBoxTD_Click_1(object sender, EventArgs e)
        {
            textBoxTD.SelectAll();
        }

        private void TextBoxTY_Click(object sender, EventArgs e)
        {
            textBoxTY.SelectAll();
        }

        private void TextBoxİNKD_Click(object sender, EventArgs e)
        {
            textBoxİNKD.SelectAll();
        }

        private void TextBoxİNKY_Click(object sender, EventArgs e)
        {
            textBoxİNKY.SelectAll();
        }

        private void TextBoxDD_Click(object sender, EventArgs e)
        {
            textBoxDD.SelectAll();
        }

        private void TextBoxDY_Click(object sender, EventArgs e)
        {
            textBoxDY.SelectAll();
        }

        private void TextBoxİNGD_Click(object sender, EventArgs e)
        {
            textBoxİNGD.SelectAll();
        }

        private void TextBoxİNGY_Click(object sender, EventArgs e)
        {
            textBoxİNGY.SelectAll();
        }

        private void TextBoxMD_Click(object sender, EventArgs e)
        {
            textBoxMD.SelectAll();
        }

        private void TextBoxMY_Click(object sender, EventArgs e)
        {
            textBoxMY.SelectAll();
        }

        private void TextBoxFD_Click(object sender, EventArgs e)
        {
            textBoxFD.SelectAll();
        }

        private void TextBoxFY_Click(object sender, EventArgs e)
        {
            textBoxFY.SelectAll();
        }       

        private void TextBoxTD_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxTD.Text.ToString()))
            {
                td = Convert.ToInt32(textBoxTD.Text);
                if (Convert.ToInt32(textBoxTD.Text) > 20)
                {
                    MessageBox.Show("Türkçe doğru sayısı 20'den büyük olamaz!");
                    td = 0;
                    textBoxTD.Text = "";
                }

                if ((td + ty) > 20)
                {
                    MessageBox.Show("Türkçe doğru ve yanlış sayısı toplamı 20'den büyük olamaz!");
                    td = 0;
                    textBoxTD.Text = "";
                }
            }                       
        }

        private void TextBoxTY_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTY.Text.ToString()))
            {
                ty = Convert.ToInt32(textBoxTY.Text);
                if (Convert.ToInt32(textBoxTY.Text) > 20)
                {
                    MessageBox.Show("Türkçe yanlış sayısı 20'den büyük olamaz!");
                    ty = 0;
                    textBoxTY.Text = "";
                }

                if ((td + ty) > 20)
                {
                    MessageBox.Show("Türkçe doğru ve yanlış sayısı toplamı 20'den büyük olamaz!");
                    ty = 0;
                    textBoxTY.Text = "";
                }
            }                                   
        }

        private void TextBoxİNKD_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxİNKD.Text.ToString()))
            {
                inkd = Convert.ToInt32(textBoxİNKD.Text);
                if (Convert.ToInt32(textBoxİNKD.Text) > 10)
                {
                    MessageBox.Show("İnkılap doğru sayısı 10'dan büyük olamaz!");
                    inkd = 0;
                    textBoxİNKD.Text = "";
                }

                if ((inkd + inky) > 10)
                {
                    MessageBox.Show("İnkılap doğru ve yanlış sayısı toplamı 10'dan büyük olamaz!");
                    inkd = 0;
                    textBoxİNKD.Text = "";
                }
            }                                 
        }

        private void TextBoxİNKY_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxİNKY.Text.ToString()))
            {
                inky = Convert.ToInt32(textBoxİNKY.Text);
                if (Convert.ToInt32(textBoxİNKY.Text) > 10)
                {
                    MessageBox.Show("İnkılap yanlış sayısı 10'dan büyük olamaz!");
                    inky = 0;
                    textBoxİNKY.Text = "";
                }

                if ((inkd + inky) > 10)
                {
                    MessageBox.Show("İnkılap doğru ve yanlış sayısı toplamı 10'dan büyük olamaz!");
                    inky = 0;
                    textBoxİNKY.Text = "";
                }
            }                
        }

        private void TextBoxDD_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDD.Text.ToString()))
            {
                dd = Convert.ToInt32(textBoxDD.Text);
                if (Convert.ToInt32(textBoxDD.Text) > 10)
                {
                    MessageBox.Show("Din Kültürü doğru sayısı 10'dan büyük olamaz!");
                    dd = 0;
                    textBoxDD.Text = "";
                }

                if ((dd + dy) > 10)
                {
                    MessageBox.Show("Din Kültürü doğru ve yanlış sayısı toplamı 10'dan büyük olamaz!");
                    dd = 0;
                    textBoxDD.Text = "";
                }
            }                
        }

        private void TextBoxDY_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDY.Text.ToString()))
            {
                dy = Convert.ToInt32(textBoxDY.Text);
                if (Convert.ToInt32(textBoxDY.Text) > 10)
                {
                    MessageBox.Show("Din Kültürü yanlış sayısı 10'dan büyük olamaz!");
                    dy = 0;
                    textBoxDY.Text = "";
                }

                if ((dd + dy) > 10)
                {
                    MessageBox.Show("Din Kültürü doğru ve yanlış sayısı toplamı 10'dan büyük olamaz!");
                    dy = 0;
                    textBoxDY.Text = "";
                }
            }                
        }

        private void TextBoxİNGD_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxİNGD.Text.ToString()))
            {
                ingd = Convert.ToInt32(textBoxİNGD.Text);
                if (Convert.ToInt32(textBoxİNGD.Text) > 10)
                {
                    MessageBox.Show("ingilizce doğru sayısı 10'dan büyük olamaz!");
                    ingd = 0;
                    textBoxİNGD.Text = "";
                }

                if ((ingd + ingy) > 10)
                {
                    MessageBox.Show("Din Kültürü doğru ve yanlış sayısı toplamı 10'dan büyük olamaz!");
                    ingd = 0;
                    textBoxİNGD.Text = "";
                }
            }                
        }

        private void TextBoxİNGY_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxİNGY.Text.ToString()))
            {
                ingy = Convert.ToInt32(textBoxİNGY.Text);
                if (Convert.ToInt32(textBoxİNGY.Text) > 10)
                {
                    MessageBox.Show("ingilizce yanlış sayısı 10'dan büyük olamaz!");
                    ingy = 0;
                    textBoxİNGY.Text = "";
                }

                if ((ingd + ingy) > 10)
                {
                    MessageBox.Show("ingilizce doğru ve yanlış sayısı toplamı 10'dan büyük olamaz!");
                    ingy = 0;
                    textBoxİNGY.Text = "";
                }
            }                
        }

        private void TextBoxMD_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxMD.Text.ToString()))
            {
                md = Convert.ToInt32(textBoxMD.Text);
                if (Convert.ToInt32(textBoxMD.Text) > 20)
                {
                    MessageBox.Show("Matematik doğru sayısı 20'den büyük olamaz!");
                    md = 0;
                    textBoxMD.Text = "";
                }

                if ((md + my) > 20)
                {
                    MessageBox.Show("Matematik doğru ve yanlış sayısı toplamı 20'den büyük olamaz!");
                    md = 0;
                    textBoxMD.Text = "";
                }
            }               
        }

        private void TextBoxMY_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxMY.Text.ToString()))
            {
                my = Convert.ToInt32(textBoxMY.Text);
                if (Convert.ToInt32(textBoxMY.Text) > 20)
                {
                    MessageBox.Show("Matematik yanlış sayısı 20'den büyük olamaz!");
                    my = 0;
                    textBoxMY.Text = "";
                }

                if ((md + my) > 20)
                {
                    MessageBox.Show("Matematik doğru ve yanlış sayısı toplamı 20'den büyük olamaz!");
                    my = 0;
                    textBoxMY.Text = "";
                }
            }               
        }

        private void TextBoxFD_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFD.Text.ToString()))
            {
                fd = Convert.ToInt32(textBoxFD.Text);
                if (Convert.ToInt32(textBoxFD.Text) > 20)
                {
                    MessageBox.Show("Fen Bilimleri doğru sayısı 20'den büyük olamaz!");
                    fd = 0;
                    textBoxFD.Text = "";
                }

                if ((fd + fy) > 20)
                {
                    MessageBox.Show("Fen Bilimleri doğru ve yanlış sayısı toplamı 20'den büyük olamaz!");
                    fd = 0;
                    textBoxFD.Text = "";
                }
            }               
        }

        private void TextBoxFY_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFY.Text.ToString()))
            {
                fy = Convert.ToInt32(textBoxFY.Text);
                if (Convert.ToInt32(textBoxFY.Text) > 20)
                {
                    MessageBox.Show("Fen Bilimleri yanlış sayısı 20'den büyük olamaz!");
                    fy = 0;
                    textBoxFY.Text = "";
                }

                if ((fd + fy) > 20)
                {
                    MessageBox.Show("Fen Bilimleri doğru ve yanlış sayısı toplamı 20'den büyük olamaz!");
                    fy = 0;
                    textBoxFY.Text = "";
                }
            }                
        }

        private void TextBoxTD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);            
        }

        private void TextBoxTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);            
        }

        private void TextBoxİNKD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxİNKY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxDY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxİNGD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxİNGY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxMD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxMY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxFD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxFY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBoxTD.Text = "";
            textBoxTY.Text = "";
            textBoxTN.Text = "";
            textBoxİNKD.Text = "";
            textBoxİNKY.Text = "";
            textBoxİNKN.Text = "";
            textBoxDD.Text = "";
            textBoxDY.Text = "";
            textBoxDN.Text = "";
            textBoxİNGD.Text = "";
            textBoxİNGY.Text = "";
            textBoxINGN.Text = "";
            textBoxMD.Text = "";
            textBoxMY.Text = "";
            textBoxMN.Text = "";
            textBoxFD.Text = "";
            textBoxFY.Text = "";
            textBoxFN.Text = "";

            textBoxPUAN.Text = "";

            td = 0;
            ty = 0;
            tnet = 0;
            inkd = 0;
            inky = 0;
            inknet = 0;
            dd = 0;
            dy = 0;
            dnet = 0;            
            ingd = 0;
            ingy = 0;
            ingnet = 0;
            md = 0;
            my = 0;
            mnet = 0;
            fd = 0;
            fy = 0;
            fnet = 0;
        }
    }
}
