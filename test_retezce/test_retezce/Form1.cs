using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_retezce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string veta1 = "_a_ nam zabili  Ferdinanda.";
        //string veta2 = "Prazdn_ retezec  ma hodnotu \"\" nebo _tring.Empty";
        //string veta3 = "Inst_nce  String je nemenn_.";
        //string veta4 = "Halda j_ prakticky __om_z__a pamet.";

        string abeceda = "abcdefghijklmnopqrstuvwxyz";


        private void button1_Click(object sender, EventArgs e)
        {           
            string veta = textBox1.Text;
            veta = veta.ToLower();
            while (veta.Contains("  "))
            {
                veta = veta.Replace("  ", " ");
            }
            textBox1.Text = veta;
            
            string[] slova = veta.Split(' ', '_');

           
            

            for (int i = 0; i < abeceda.Length; i++)
            {
                if (!(veta.Contains(abeceda[i])))
                {
                    listBox1.Items.Add(abeceda[i]);
                }
                

            }



            string veta2 = veta;
            

            char[] pole_pismen = veta2.ToCharArray();
            Array.Sort(pole_pismen);            
            int pocet_char = 0;
            int max_char = 0;
            char max_c = 'a';
            char znak = 'a';
                                   
            foreach (char c in pole_pismen)
            {
                //MessageBox.Show(((char)(znak)).ToString());                
                if (abeceda.Contains(c))
                {                                        
                    if (c != znak)
                    {                        
                        znak++;
                        pocet_char = 0;
                    }
                    if (c == znak)
                    {
                        pocet_char++;
                    }
                    if (max_char < pocet_char)
                    {
                        max_char = pocet_char;
                        max_c = c;
                        pocet_char = 0;
                    }
                    //MessageBox.Show(max_char.ToString());
                    //MessageBox.Show(znak.ToString());

                }
            }
            label4.Text += " " + max_c.ToString();

            










        }
    }
}
