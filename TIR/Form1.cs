using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TIR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            pictureBox5.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = false ;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false ;
            pictureBox14.Visible = false;
            pictureBox13.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (pictureBox5.Right > this.ClientSize.Width)//tufeng ucun(eger ekrani kecse timer dayansin ve baslangic kordinatina qayitsin)
            {
                timer1.Stop();
                pictureBox5.Left = pictureBox1.Right;
                fail++;
                label6.Text = fail.ToString();
                pictureBox5.Visible = false;

            }
            if (pictureBox11.Right > this.ClientSize.Width)//bazuka ucun(eger ekrani kecse timer dayansin ve baslangic kordinatina qayitsin)
            {
                timer1.Stop();
                pictureBox11.Left = pictureBox12.Right;
                fail++;
                label6.Text = fail.ToString();
               

            }

            if (pictureBox1.Visible == false)
            {
                bazuka.Start();
                timer1.Stop();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                pictureBox5.Visible = false ;
                pictureBox7.Visible = false;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
               
               
            }
            else
            {
                timer1.Start();
                pictureBox5.Visible = true;
                pictureBox7.Visible = true;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
            }
            
            
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            pictureBox5.Left = pictureBox5.Left + 12 ;

            if(pictureBox3.Left<pictureBox5.Right&&
                pictureBox5.Bottom>pictureBox3.Top&&
                pictureBox5.Bottom<pictureBox3.Bottom)
            {
               
                timer1.Stop();


            }
            
            if (pictureBox4.Left < pictureBox5.Right &&
                pictureBox5.Bottom > pictureBox4.Top &&
                pictureBox5.Bottom < pictureBox4.Bottom)
            {
               
                timer1.Stop();

            }
            if (pictureBox2.Left < pictureBox5.Right &&
                pictureBox5.Bottom > pictureBox2.Top &&
                pictureBox5.Bottom < pictureBox2.Bottom)
            {
               
                timer1.Stop();

            }
            if (pictureBox5.Left>pictureBox7.Right)
            {
                pictureBox7.Visible = false;
                
            }

            if(pictureBox5.Right>this.ClientSize.Width)
            {
                timer1.Stop();
                
                pictureBox5.Left = pictureBox1.Right;
                fail++;
                label6.Text = fail.ToString();
                pictureBox5.Visible = false;
                
            }


            
        }
        int SAY = 0;
        int zombie = 0;
        int fail = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Left--;
            if (pictureBox3.Left < pictureBox5.Right &&
                pictureBox5.Bottom > pictureBox3.Top &&
                pictureBox5.Bottom < pictureBox3.Bottom)
            {

                SAY++;
                label1.Text = SAY.ToString();
                pictureBox3.Left = this.ClientSize.Width - 80;
                pictureBox5.Left = pictureBox1.Right;
                pictureBox5.Visible = false;
                

            }



            
            if (pictureBox6.Right > pictureBox3.Left)
            {
                timer2.Stop();

                pictureBox3.Left = this.ClientSize.Width - 80;
                label1.Text = 0.ToString();
                zombie++;
                label4.Text = zombie.ToString();
                pictureBox5.Left = pictureBox1.Right;

                if (zombie == 1)
                {
                    pictureBox10.Visible = false;

                }
                if (zombie == 2)
                {
                    pictureBox9.Visible = false;

                }
                if (zombie == 3)
                {
                    zombie = 0;
                    pictureBox8.Visible = false;

                    Form2 w = new Form2();
                    this.Opacity = this.Opacity + 0.01;
                    w.ShowDialog();
                    //ceehdlerin sayin 0 elemek ucun
                    fail = 0;
                    label6.Text = fail.ToString();

                }


            }

            //bazukanin gullesi ucun
           



            
            if (pictureBox5.Right > this.ClientSize.Width)//tufeng ucun(eger ekrani kecse timer dayansin ve baslangic kordinatina qayitsin)
            {
                timer1.Stop();
                pictureBox5.Left = pictureBox1.Right;
                fail++;
                label6.Text = fail.ToString();
                pictureBox5.Visible = false;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {


        }//lazimsiz

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //silahin asagi hereketi
            if(e.KeyCode==Keys.S)
            {
                pictureBox1.Top = pictureBox1.Top+5;
                pictureBox5.Top = pictureBox5.Top + 5;
                pictureBox7.Top = pictureBox7.Top + 5;
            }
            //silahin yuxari hereketi
            if (e.KeyCode == Keys.W)
            {
                pictureBox1.Top = pictureBox1.Top - 5;
                pictureBox5.Top = pictureBox5.Top - 5;
                pictureBox7.Top = pictureBox7.Top - 5;
                pictureBox5.Visible = false;
            }




            //bazukanin asagi hereketi
            if (e.KeyCode == Keys.S)
            {
                pictureBox11.Top = pictureBox11.Top + 5;
                pictureBox12.Top = pictureBox12.Top + 5;
                pictureBox13.Top = pictureBox13.Top + 5;
                pictureBox14.Top = pictureBox14.Top + 5;
            }
            //bazukanin yuxari hereketi
            if (e.KeyCode == Keys.W)
            {
                pictureBox11.Top = pictureBox11.Top - 5;
                pictureBox12.Top = pictureBox12.Top - 5;
                pictureBox13.Top = pictureBox13.Top - 5;
                pictureBox14.Top = pictureBox14.Top - 5;

            }



        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }//lazimsiz

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left--;
            if (pictureBox2.Left < pictureBox5.Right &&
                pictureBox5.Bottom > pictureBox2.Top &&
                pictureBox5.Bottom < pictureBox2.Bottom)
            {

                SAY++;
                label1.Text = SAY.ToString();
                pictureBox2.Left = this.ClientSize.Width - 80;
                pictureBox5.Left = pictureBox1.Right;
                pictureBox5.Visible = false;

            }

           



            if (pictureBox6.Right > pictureBox2.Left)
            {
                timer3.Stop();
               
                pictureBox2.Left = this.ClientSize.Width - 80;
                label1.Text = 0.ToString();
                zombie++;
                label4.Text = zombie.ToString();
                pictureBox5.Left = pictureBox1.Right;
                if (zombie == 1) 
                {
                    pictureBox10.Visible = false;

                }
                if (zombie == 2)
                {
                    pictureBox9.Visible = false;

                }
                if (zombie == 3)
                {
                    zombie = 0;
                    pictureBox8.Visible = false;
                    
                    Form2 w = new Form2();
                    this.Opacity = this.Opacity + 0.01;
                    w.ShowDialog();
                    fail = 0;
                    label6.Text = fail.ToString();
                }
                
            }
        }//timer3

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left--;
            if (pictureBox4.Left < pictureBox5.Right &&
                pictureBox5.Bottom > pictureBox4.Top &&
                pictureBox5.Bottom < pictureBox4.Bottom)
            {

                SAY++;
                label1.Text = SAY.ToString();
                pictureBox4.Left = this.ClientSize.Width - 80;
                pictureBox5.Left = pictureBox1.Right;
                pictureBox5.Visible = false;
            }

            


            if (pictureBox6.Right > pictureBox4.Left)
            {
                timer4.Stop();
               
                pictureBox4.Left = this.ClientSize.Width - 80;
                label1.Text = 0.ToString();
                zombie++;
                label4.Text = zombie.ToString();
                pictureBox5.Left = pictureBox1.Right;
                if (zombie == 1)
                    if (zombie == 1)
                    {
                        pictureBox10.Visible = false;

                    }
                if (zombie == 2)
                {
                    pictureBox9.Visible = false;

                }
                if (zombie == 3)
                {
                    zombie = 0;
                    pictureBox8.Visible = false;
                    Form2 w = new Form2();
                    this.Opacity = this.Opacity + 0.01;
                    w.ShowDialog();
                    fail = 0;
                    label6.Text = fail.ToString();
                }
                
                   

                

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop(); 
            bazuka.Stop();
            MessageBox.Show("PAUSE:)");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //bazukanin gorunmesi ucun
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            
            //tufengin sondurulmesi ucun
            pictureBox5.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false ;
            pictureBox9.Visible = false ;
            pictureBox10.Visible = false ;
            pictureBox1.Visible = false;

        }
        int bs = 0;//bazukanin baslangic sureti
       

        private void bazuka_Tick(object sender, EventArgs e)
        {
            bs++;
            
            pictureBox11.Left = pictureBox11.Left + bs;//bazukanin suretinin artamsi ucun
            pictureBox14.Left = pictureBox14.Left + bs;//bazukanin atesinin sureti
            if(pictureBox11.Left>this.ClientSize.Width)
            {
                bazuka.Stop();
                bs = 0;
                pictureBox11.Left = pictureBox12.Right;
                pictureBox14.Left = pictureBox12.Right-50;
                pictureBox14.Visible = false;
                fail++;
                label6.Text = fail.ToString();
            }


            if(pictureBox11.Left>pictureBox12.Right+10)
            {
                pictureBox13.Visible = false;
              
               
            }


            if (pictureBox2.Left < pictureBox11.Right &&
             pictureBox11.Bottom > pictureBox2.Top &&
             pictureBox11.Bottom < pictureBox2.Bottom)
            {

                SAY++;
                label1.Text = SAY.ToString();
                pictureBox2.Left = this.ClientSize.Width - 80;
                pictureBox11.Left = pictureBox12.Right;
                pictureBox14.Left = pictureBox12.Right - 50;
                pictureBox14.Visible = false;
                bs = 0;
                bazuka.Stop();
            }

            if (pictureBox3.Left < pictureBox11.Right &&
              pictureBox11.Bottom > pictureBox3.Top &&
              pictureBox11.Bottom < pictureBox3.Bottom)
            {

                SAY++;
                label1.Text = SAY.ToString();
                pictureBox3.Left = this.ClientSize.Width - 80;
                pictureBox11.Left = pictureBox12.Right;
                pictureBox14.Left = pictureBox12.Right - 50;
                pictureBox14.Visible = false;
                bs = 0;
                bazuka.Stop();
            }
            if (pictureBox4.Left < pictureBox11.Right &&
             pictureBox11.Bottom > pictureBox4.Top &&
             pictureBox11.Bottom < pictureBox4.Bottom)
            {

                SAY++;
                label1.Text = SAY.ToString();
                pictureBox4.Left = this.ClientSize.Width - 80;
                pictureBox11.Left = pictureBox12.Right;
                pictureBox14.Left = pictureBox12.Right - 50;
                pictureBox14.Visible = false;
                bs = 0;
                bazuka.Stop();
            }




        }


  private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox5.Visible = false ;
            pictureBox7.Visible = false ;


            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
        }

 private void pictureBox11_Click(object sender, EventArgs e)
        {
           
        }//lzimsiz

      
    }
}
