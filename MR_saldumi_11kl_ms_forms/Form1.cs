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
            if (krabitis.Checked == true)
            {
                krabisa_cena();
            }
            else if (delfins.Checked == true)
            {
                delfina_cena();
            }
            else if (bocka.Checked == true)
            {
                bockas_cena();
            }
            else if (bocka.Checked == true && delfins.Checked == true)
            {
                aprekinasana();
            }
            else if(bocka.Checked == true && krabitis.Checked == true)
            {
                aprekinasana2();
            }
            else if ( krabitis.Checked == true && delfins.Checked == true)
            {
                aprekinasana3();
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
        public void krabisa_cena()
        {
            if (krabitis.Checked == true) //pārbaudu vai atķeksēta krabīša konfekšu marka 
            {
                try
                {
                    double naudas_daudzums = Convert.ToDouble(teksts.Text);
                    double nauda = naudas_daudzums;
                    double cena = 7.99;
                    double kilogramu_daudzums = naudas_daudzums / cena;
                    rezultats.Text = kilogramu_daudzums.ToString();
                }
                catch(Exception )
                {
                    MessageBox.Show("Nomirsti idiot atkal nepareizi ievadiji naudas daudzumu");
                }
                

            }

        }

        private void delfins_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void delfina_cena()
        {
            if (delfins.Checked == true)
            {
                try
                {
                    double naudas_daudzums = Convert.ToDouble(teksts.Text);
                    double nauda = naudas_daudzums;
                    double cena = 5.99;
                    double kilogramu_daudzums = naudas_daudzums / cena;
                    rezultats.Text = kilogramu_daudzums.ToString();
                }
                catch(Exception )
                {
                    MessageBox.Show("Nebija ievadits korekts naudas daudzums!");
                }
               
            }
            else
            {

            }
        }
        private void bocka_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void bockas_cena()
        {
            if (bocka.Checked == true)  
            {
                try
                {
                    double naudas_daudzums = Convert.ToDouble(teksts.Text);
                    double nauda = naudas_daudzums;
                    double cena = 20.99;
                    double kilogramu_daudzums = naudas_daudzums / cena;
                    rezultats.Text = kilogramu_daudzums.ToString();
                }
                catch(Exception )
                {
                    MessageBox.Show("Nepareizi ievaditi dati naudas daudzuma laukuma!");
                }
            }
            else
            {
                MessageBox.Show("Nav izveleta konfeksu marka!");
            }
        }

        public void aprekinasana()
        {
            if (bocka.Checked == true && delfins.Checked == true)
            {
                try
                     {


                    double naudas_daudzums = Convert.ToDouble(teksts.Text);
                    double nauda = naudas_daudzums;
                    double cena = 20.99 + 5.99;
                    double kilogramu_daudzums = naudas_daudzums / cena;
                    rezultats.Text = kilogramu_daudzums.ToString();
                     }
                catch(Exception )
                    {
                    MessageBox.Show("Nav ievadits kkads lielums!");
                    }
                   
            }
        }
        public void aprekinasana2()
        {
            if (bocka.Checked == true && krabitis.Checked == true)
            {
                double naudas_daudzums = Convert.ToDouble(teksts.Text);
                double nauda = naudas_daudzums;
                double cena = 20.99 + 7.99;
                double kilogramu_daudzums = naudas_daudzums / cena;
                rezultats.Text = kilogramu_daudzums.ToString();
            }
        }
        public void aprekinasana3() //pārbaudu vai atķeksēta konkrētā konfekšu marku izvēle
        {
            if (krabitis.Checked == true && delfins.Checked == true)
            {
                double naudas_daudzums = Convert.ToDouble(teksts.Text);
                double nauda = naudas_daudzums;
                double cena = 20.99 + 5.99;
                double kilogramu_daudzums = naudas_daudzums / cena;
                rezultats.Text = kilogramu_daudzums.ToString();
            }
            else
            {
                double naudas_daudzums = Convert.ToDouble(teksts.Text);
                double nauda = naudas_daudzums;
                double cena = 9.88;
                double kilogramu_daudzums = naudas_daudzums / cena;
                rezultats.Text = kilogramu_daudzums.ToString();
            }
        }
    }
}
