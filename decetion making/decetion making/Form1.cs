﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decetion_making
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            int text_1 = Convert.ToInt32(textBox1.Text);
            int text_2 = Convert.ToInt32(textBox9.Text);
            int text_3 = Convert.ToInt32(textBox8.Text);
            int text_4 = Convert.ToInt32(textBox7.Text);
            int text_5 = Convert.ToInt32(textBox6.Text);
            int text_6 = Convert.ToInt32(textBox5.Text);
            int text_7 = Convert.ToInt32(textBox4.Text);
            int text_8 = Convert.ToInt32(textBox3.Text);
            int text_9 = Convert.ToInt32(textBox2.Text);





            if (text_1 > text_2 && text_1 > text_3)
            {
                label17.Text = text_1.ToString();
            }
            else if (text_2 > text_1 && text_2 > text_3)
            {
                label17.Text = text_2.ToString();

            }
            else if (text_3 > text_1 && text_3 > text_2)
            {
                label17.Text = text_3.ToString();

            }
            ////////////////////////////////////////////////////////////////////////////
            if (text_4 > text_5 && text_4 > text_6)
            {
                label16.Text = text_4.ToString();
            }
            else if (text_5 > text_4 && text_5 > text_6)
            {
                label16.Text = text_5.ToString();

            }
            else if (text_6 > text_4 && text_6 > text_5)
            {
                label16.Text = text_6.ToString();

            }
            /////////////////////////////////////////////////////////////
            if (text_7 > text_8 && text_7 > text_9)
            {
                label15.Text = text_7.ToString();
            }
            else if (text_8 > text_7 && text_8 > text_9)
            {
                label15.Text = text_8.ToString();

            }
            else if (text_9 > text_7 && text_9 > text_8)
            {
                label15.Text = text_9.ToString();

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int la_1 = Convert.ToInt32(label17.Text);
            int la_2 = Convert.ToInt32(label16.Text);
            int la_3 = Convert.ToInt32(label15.Text);

            if (la_1 > la_2 && la_1 > la_3)
            {
                label9.Text = la_1.ToString();
            }
            else if (la_2 > la_1 && la_2 > la_3)
            {
                label9.Text = la_2.ToString();
            }
            else if (la_3 > la_2 && la_3 > la_1)
            {
                label9.Text = la_3.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int text_1 = Convert.ToInt32(textBox1.Text);
            int text_2 = Convert.ToInt32(textBox9.Text);
            int text_3 = Convert.ToInt32(textBox8.Text);
            int text_4 = Convert.ToInt32(textBox7.Text);
            int text_5 = Convert.ToInt32(textBox6.Text);
            int text_6 = Convert.ToInt32(textBox5.Text);
            int text_7 = Convert.ToInt32(textBox4.Text);
            int text_8 = Convert.ToInt32(textBox3.Text);
            int text_9 = Convert.ToInt32(textBox2.Text);

            if (text_1 < text_2 && text_1 < text_3)
            {
                label14.Text = text_1.ToString();
            }
            else if (text_2 < text_1 && text_2 < text_3)
            {
                label14.Text = text_2.ToString();

            }
            else if (text_3 < text_1 && text_3 < text_2)
            {
                label14.Text = text_3.ToString();

            }
            ////////////////////////////////////////////////////////////////////////////
            if (text_4 < text_5 && text_4 < text_6)
            {
                label13.Text = text_4.ToString();
            }
            else if (text_5 < text_4 && text_5 < text_6)
            {
                label13.Text = text_5.ToString();

            }
            else if (text_6 < text_4 && text_6 < text_5)
            {
                label13.Text = text_6.ToString();

            }
            /////////////////////////////////////////////////////////////
            if (text_7 < text_8 && text_7 < text_9)
            {
                label12.Text = text_7.ToString();
            }
            else if (text_8 < text_7 && text_8 < text_9)
            {
                label12.Text = text_8.ToString();

            }
            else if (text_9 < text_7 && text_9 < text_8)
            {
                label12.Text = text_9.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int la_1 = Convert.ToInt32(label14.Text);
            int la_2 = Convert.ToInt32(label13.Text);
            int la_3 = Convert.ToInt32(label12.Text);

            if (la_1 > la_2 && la_1 > la_3)
            {
                label8.Text = la_1.ToString();
            }
            else if (la_2 > la_1 && la_2 > la_3)
            {
                label8.Text = la_2.ToString();
            }
            else if (la_3 > la_2 && la_3 > la_1)
            {
                label8.Text = la_3.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int text_1 = Convert.ToInt32(textBox10.Text);
            int text_2 = Convert.ToInt32(textBox13.Text);
            int text_3 = Convert.ToInt32(textBox16.Text);
            int text_4 = Convert.ToInt32(textBox11.Text);
            int text_5 = Convert.ToInt32(textBox14.Text);
            int text_6 = Convert.ToInt32(textBox17.Text);
            int text_7 = Convert.ToInt32(textBox12.Text);
            int text_8 = Convert.ToInt32(textBox15.Text);
            int text_9 = Convert.ToInt32(textBox18.Text);

            if (text_1 > text_2 && text_1 > text_3)
            {
                label25.Text = text_1.ToString();
            }
            else if (text_2 > text_1 && text_2 > text_3)
            {
                label25.Text = text_2.ToString();
            }
            else if (text_3 > text_1 && text_3 > text_2)
            {
                label25.Text = text_3.ToString();
            }
            ////////////////////////////////////////////////////////////////////////////
            if (text_4 > text_5 && text_4 > text_6)
            {
                label26.Text = text_4.ToString();
            }
            else if (text_5 > text_4 && text_5 > text_6)
            {
                label26.Text = text_5.ToString();

            }
            else if (text_6 > text_4 && text_6 > text_5)
            {
                label26.Text = text_6.ToString();

            }
            /////////////////////////////////////////////////////////////
            if (text_7 > text_8 && text_7 > text_9)
            {
                label27.Text = text_7.ToString();
            }
            else if (text_8 > text_7 && text_8 > text_9)
            {
                label27.Text = text_8.ToString();

            }
            else if (text_9 > text_7 && text_9 > text_8)
            {
                label27.Text = text_9.ToString();

            }

        



        }



        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int text_1 = Convert.ToInt32(textBox1.Text);
                int text_4 = Convert.ToInt32(textBox7.Text);
                int text_7 = Convert.ToInt32(textBox4.Text);
                /////////////////////////////////////////
                int text_2 = Convert.ToInt32(textBox9.Text);
                int text_5 = Convert.ToInt32(textBox6.Text);
                int text_8 = Convert.ToInt32(textBox3.Text);
                ////////////////////////////////////////////
                int text_3 = Convert.ToInt32(textBox8.Text);
                int text_6 = Convert.ToInt32(textBox5.Text);
                int text_9 = Convert.ToInt32(textBox2.Text);







                //int lab_10 = Convert.ToInt32(text.Text);

                if (text_1 > text_4 && text_1 > text_7)
                {
                    textBox10.Text = ((text_1 - text_1)).ToString();
                }
                else if (text_4 > text_1 && text_4 > text_7)
                {
                    textBox10.Text = ((text_4 - text_1)).ToString();
                }
                else if (text_7 > text_1 && text_7 > text_4)
                {
                    textBox10.Text = ((text_7 - text_1)).ToString();
                }
                ////////////////////////////////////////
                if (text_1 > text_4 && text_1 > text_7)
                {
                    textBox11.Text = ((text_1 - text_4)).ToString();
                }
                else if (text_4 > text_1 && text_4 > text_7)
                {
                    textBox11.Text = ((text_4 - text_4)).ToString();
                }
                else if (text_7 > text_1 && text_7 > text_4)
                {
                    textBox11.Text = ((text_7 - text_4)).ToString();
                }
                ///////////////////////////////////////
                if (text_1 > text_4 && text_1 > text_7)
                {
                    textBox12.Text = ((text_1 - text_7)).ToString();
                }
                else if (text_4 > text_1 && text_4 > text_7)
                {
                    textBox12.Text = ((text_4 - text_7)).ToString();
                }
                else if (text_7 > text_1 && text_7 > text_4)
                {
                    textBox12.Text = ((text_7 - text_7)).ToString();
                }
                ///////////////////////////////////////////////////
                if (text_2 > text_5 && text_2 > text_8)
                {
                    textBox13.Text = ((text_2 - text_2)).ToString();
                }
                else if (text_5 > text_2 && text_5 > text_8)
                {
                    textBox13.Text = ((text_5 - text_2)).ToString();
                }
                else if (text_8 > text_2 && text_8 > text_5)
                {
                    textBox13.Text = ((text_8 - text_2)).ToString();
                }
                ////////////////////////////////////////////////////
                if (text_2 > text_5 && text_2 > text_8)
                {
                    textBox14.Text = ((text_2 - text_5)).ToString();
                }
                else if (text_5 > text_2 && text_5 > text_8)
                {
                    textBox14.Text = ((text_5 - text_5)).ToString();
                }
                else if (text_8 > text_2 && text_8 > text_5)
                {
                    textBox14.Text = ((text_8 - text_5)).ToString();
                }
                //////////////////////////////////////////////////////
                if (text_2 > text_5 && text_2 > text_8)
                {
                    textBox15.Text = ((text_2 - text_8)).ToString();
                }
                else if (text_5 > text_2 && text_5 > text_8)
                {
                    textBox15.Text = ((text_5 - text_8)).ToString();
                }
                else if (text_8 > text_2 && text_8 > text_5)
                {
                    textBox15.Text = ((text_8 - text_8)).ToString();
                }
                ////////////////////////////////////////////////////////////
                if (text_3 > text_6 && text_3 > text_9)
                {
                    textBox16.Text = ((text_3 - text_3)).ToString();
                }
                else if (text_5 > text_2 && text_5 > text_8)
                {
                    textBox16.Text = ((text_6 - text_3)).ToString();
                }
                else if (text_8 > text_2 && text_8 > text_5)
                {
                    textBox16.Text = ((text_9 - text_3)).ToString();
                }
                /////////////////////////////////////////////////////////////////
                if (text_3 > text_6 && text_3 > text_9)
                {
                    textBox17.Text = ((text_3 - text_6)).ToString();
                }
                else if (text_5 > text_2 && text_5 > text_8)
                {
                    textBox17.Text = ((text_6 - text_6)).ToString();
                }
                else if (text_8 > text_2 && text_8 > text_5)
                {
                    textBox17.Text = ((text_9 - text_6)).ToString();
                }
                ///////////////////////////////////////////
                if (text_3 > text_6 && text_3 > text_9)
                {
                    textBox18.Text = ((text_3 - text_9)).ToString();
                }
                else if (text_5 > text_2 && text_5 > text_8)
                {
                    textBox18.Text = ((text_6 - text_9)).ToString();
                }
                else if (text_8 > text_2 && text_8 > text_5)
                {
                    textBox18.Text = ((text_9 - text_9)).ToString();
                }
            }




            catch
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {







        }
    }
}
