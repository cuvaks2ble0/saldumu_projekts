using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MR_saldumi_11kl_ms_forms
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kopeja_cena = 0;
            if(krabitis.Checked == true)
            {
                kopeja_cena += 7.99;
            }
            else if (delfins.Checked == true)
            {
                kopeja_cena += 5.99;
            }
            else if(bocka.Checked == true)
            {
                kopeja_cena += 20.99;
            }
            else
            {
                try
                {
                    double naudas_daudzums = Convert.ToDouble(teksts.Text);
                    double nauda = naudas_daudzums;
                    double kilogramu_daudzums = naudas_daudzums / kopeja_cena;
                    rezultats.Text = kilogramu_daudzums.ToString();
                }
                catch(Exception)
                {
                    MessageBox.Show("Nav izveleta konfeksu marka");
                }

            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rezultats_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
       

        private void delfins_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void bocka_CheckedChanged(object sender, EventArgs e)
        {

        }
     
        public void cekins() // aprekinu miskastes masinas ceka izdrukas faila dokumentu 
        {

        }
    }
}
