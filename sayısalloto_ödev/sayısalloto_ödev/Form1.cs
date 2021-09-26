using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayısalloto_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static int c_say = 0;
        public static int[] c_sayilar = new int[6];
        public static TextBox[] cekilis_pan = new TextBox[6]; 


        public static int Random_say_cen()
        {
            Random rmd1 = new Random();

            c_say = rmd1.Next(100000,999999);


            return c_say ;

        }

      
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            bool form_tm = false;
            bool t7 = false;
            bool t8 = false;
            bool t9 = false;
            bool t10 = false;
            bool t11 = false;
            bool t12 = false;

            /*
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            */




            // int test_orn = 123456;
            if (Convert.ToInt32( textBox7.Text) >= 0 || Convert.ToInt32(textBox7.Text) <= 9) 
            {
                t7 = true;
            };
            if (Convert.ToInt32(textBox8.Text) >= 0 && Convert.ToInt32(textBox8.Text) <= 9)
            {
                t8 = true;
            }
            if (Convert.ToInt32(textBox9.Text) >= 0 && Convert.ToInt32(textBox9.Text) <= 9)
            {
                t9 = true;
            }
            if (Convert.ToInt32(textBox10.Text) >= 0 && Convert.ToInt32(textBox10.Text) <= 9)
            {
                t10 = true;
            }
            if (Convert.ToInt32(textBox11.Text) >= 0 && Convert.ToInt32(textBox11.Text) <= 9)
            {
                t11 = true;
            }
            if (Convert.ToInt32(textBox12.Text) >= 0 && Convert.ToInt32(textBox12.Text) <= 9)
            {
                t12 = true;
            }

            if (t7 && t9 && t10 && t11 && t12 == true )
            {
                form_tm = true;
            }

            if (form_tm == true) {

                Random_say_cen();


                int sec_say = c_say;

                char[] sayı_c;



                string sayı = sec_say.ToString();


                sayı_c = sayı.ToCharArray();


                /*int i = 0;
                textBox1.Text = c_say.ToString();
                foreach (char c in sayı_c) 

                {

                     //syı[i] = c;

                };

                //  textBox6.Text = syı[5].ToString();

                //c_say.ToString*/

                cekilis_pan[1] = textBox2;
                cekilis_pan[2] = textBox3;
                cekilis_pan[3] = textBox4;
                cekilis_pan[4] = textBox5;
                cekilis_pan[5] = textBox6;


                char[] syı = sayı.ToCharArray(0, 6);
                //textBox1.Tex
                textBox5.Text = syı[4].ToString();
                textBox1.Text = syı[0].ToString();
                textBox2.Text = syı[1].ToString();
                textBox3.Text = syı[2].ToString();
                textBox4.Text = syı[3].ToString();
                textBox6.Text = syı[5].ToString();



                if (textBox1.Text == textBox7.Text ) 
                {
                    panel2.BackColor = Color.Green;


                }
                else 
                {
                    panel2.BackColor = Color.Red;
                }


                if (textBox2.Text == textBox8.Text)
                {
                    panel3.BackColor = Color.Green;


                }
                else
                {
                    panel3.BackColor = Color.Red;
                }


                if (textBox3.Text == textBox9.Text)
                {
                    panel4.BackColor = Color.Green;


                }
                else
                {
                    panel4.BackColor = Color.Red;
                }

                if (textBox4.Text == textBox10.Text)
                {
                    panel5.BackColor = Color.Green;


                }
                else
                {
                    panel5.BackColor = Color.Red;
                }


                if (textBox5.Text == textBox11.Text)
                {
                    panel6.BackColor = Color.Green;


                }
                else
                {
                    panel6.BackColor = Color.Red;
                }


                if (textBox6.Text == textBox12.Text)
                {
                    panel7.BackColor = Color.Green;


                }
                else
                {
                    panel7.BackColor = Color.Red;
                }


                /*cekilis_pan[0].Text = syı[0].ToString();
                cekilis_pan[1].Text = syı[1].ToString();
                cekilis_pan[2].Text = syı[2].ToString();
                cekilis_pan[3].Text = syı[3].ToString();
                cekilis_pan[4].Text = syı[4].ToString();
                cekilis_pan[5].Text = syı[5].ToString();*/






                /*int a =0;


                int sayı_U1 = 0;
                int sayı_U2 = 5;
                int sayı_U3 = 0;
                int sayı_U4 = 0;
                int sayı_U5 = 0;
                int sayı_U6 = 0;


                //sayı_U1 = c_say;

                cekilis_pan[1] = textBox2;
                cekilis_pan[2] = textBox3;
                cekilis_pan[3] = textBox4;
                cekilis_pan[4] = textBox5;
                cekilis_pan[5] = textBox6;



                /*
                cekilis_pan[0].Text = sayı_U1.ToString();
                cekilis_pan[1].Text = sayı_U2.ToString();
                cekilis_pan[2].Text = sayı_U3.ToString();
                cekilis_pan[3].Text = sayı_U4.ToString();
                cekilis_pan[4].Text = sayı_U5.ToString();
                cekilis_pan[5].Text = sayı_U6.ToString();*/


                // int rep_sec = 0;
                // rep_sec = cekilis_pan.Text.

                /* int i = 0;
                 while(i <= 5) 
                 {
                     Random_say_cen();

                     cekilis_pan[i].Text = c_say.ToString();


                         /*if ( == true) 
                         {

                         }



                     i++;

                 };*/

















            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
