using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre__Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int salise = 0;
        int saniye = 0;
        int dakika = 0;
        int saat = 0;
        string saliseText = "00";
        string saniyeText = "00";
        string dakikaText = "00";
        string saatText = "00";
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "00";
            textBox2.Text = "00";
            textBox3.Text = "00";
            textBox4.Text = "00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true && radioButton2.Checked==false)
            {
                salise++;
                if (salise == 60) { salise = 0;saniye++; }
                if (saniye == 60) { saniye = 0;dakika++; }
                if (dakika == 60) { dakika = 0;saat++; }
                if (salise < 10) saliseText = "0" + salise;
                else if (salise >= 10) saliseText = ""+salise;
                if (saniye < 10) saniyeText = "0" + saniye;
                else if (saniye >= 10) saniyeText = "" + saniye;
                if (dakika < 10) dakikaText = "0" + dakika;
                else if (dakika >= 10) dakikaText = "" + dakika;
                if (saat < 10) saatText = "0" + saat;
                else if (saat >= 10) saatText = "" + saat;
                textBox4.Text = saliseText;
                textBox3.Text = saniyeText;
                textBox2.Text = dakikaText;
                textBox1.Text = saatText;


            }
            else if(radioButton1.Checked==false&&radioButton2.Checked==true)
            {
                salise--;
                if (salise == -1) { salise = 59;saniye--;}
                if (saniye == -1) { saniye = 59;dakika--; }
                if (dakika == -1) { dakika = 59;saat--; }
                if (salise < 10) saliseText = "0" + salise;
                else if (salise >= 10) saliseText = "" + salise;
                if (saniye < 10) saniyeText = "0" + saniye;
                else if (saniye >= 10) saniyeText = "" + saniye;
                if (dakika < 10) dakikaText = "0" + dakika;
                else if (dakika >= 10) dakikaText = "" + dakika;
                if (saat < 10) saatText = "0" + saat;
                else if (saat >= 10) saatText = "" + saat;
                textBox4.Text = saliseText;
                textBox3.Text = saniyeText;
                textBox2.Text = dakikaText;
                textBox1.Text = saatText;
                if (saat == 0 && dakika == 0 && saniye == 0 && salise == 0) timer1.Stop();


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Text = "Başla";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Text = "Devam Et";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salise = 0;
            saniye = 0;
            dakika = 0;
            saat = 0;
            textBox1.Text = "00";
            textBox2.Text = "00";
            textBox3.Text = "00";
            textBox4.Text = "00";
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;

            button5.Visible = true;
            button6.Visible = true;

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;

            timer1.Stop();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;

            button5.Visible = false;
            button6.Visible = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try 
            {
                salise = Int32.Parse(textBox4.Text);
                saniye = Int32.Parse(textBox3.Text);
                dakika = Int32.Parse(textBox2.Text);
                saat = Int32.Parse(textBox1.Text);
                if (salise > 59 || salise < 0 || saniye > 59 || saniye < 0 || dakika > 59 || dakika < 0 || saat < 0)
                    Convert.ToInt32("abc");

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;

                button5.Visible = false;
                button6.Visible = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Girdiğiniz değerlerde hata var", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
