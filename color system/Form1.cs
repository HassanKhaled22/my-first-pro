using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color_system
{
    public partial class Form1 : Form
    {

       
        Form2 f;
       
        //method to do rule one
        public void rule1(int x)
        {


            f = new Form2(this);
            f.btn1.Visible = f.btn2.Visible = true;
            Button[] all ={ btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8,
                            btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17 };
          
           if(x<=8)
            {
                f.btn1.BackColor = all[x].BackColor;
                f.btn2.BackColor = all[9 + x].BackColor;
            }
           else
            {

                f.btn1.BackColor = all[x].BackColor;
                f.btn2.BackColor = all[x - 9].BackColor;
            }
            f.Show();
        }
        //public void rule2(int x)
        //{
        //    //f = new Form2(this);
        //    Button[] all={ btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 ,
        //        btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17 };

        //   if(x==6||x==7||x==8)
        //    {
        //        x = 6;
        //    }
        //   else if (x==15||x==16||x==17)
        //    {
        //        x = 15;
        //    }

        //    f.btn1.BackColor = all[x].BackColor;
        //    f.btn2.BackColor = all[x + 1].BackColor;
        //    f.btn3.BackColor = all[x + 2].BackColor;





        //}
        //method to do rule two
        public void rule3(int x)
        {


            f = new Form2(this);
            f.btn1.Visible = f.btn2.Visible = f.btn3.Visible=true;

            Button[] all ={ btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7,
                btn8,btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17 };

               f.btn1.BackColor = all[x].BackColor;
            if (x <= 7)
            {
                f.btn2.BackColor = all[x + 2].BackColor;
                f.btn3.BackColor = all[x + 10].BackColor;

            }
            else if (x <= 15)
            {
                f.btn2.BackColor = all[x + 2].BackColor;
                f.btn3.BackColor = all[x - 8].BackColor;
            }
            else
            {
                f.btn2.BackColor = all[x-16].BackColor;
                f.btn3.BackColor = all[x - 8].BackColor;
            }

            f.Show();


        }
        //method to do rule four
        public void rule4(int x)
        {
           
            f = new Form2(this);

            f.btn1.Visible = f.btn2.Visible = f.btn3.Visible = f.btn4.Visible = true;

            Button[] all ={ btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7,
                btn8,btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17 };

            f.btn1.BackColor = all[x].BackColor;
            if(x<=6)

            {
                f.btn2.BackColor = all[x + 2].BackColor;
                f.btn3.BackColor = all[x + 9].BackColor;
                f.btn4.BackColor = all[x + 11].BackColor;

            }
            else if(x<=8)
            {
                f.btn2.BackColor = all[x + 2].BackColor;
                f.btn3.BackColor = all[x -7].BackColor;
                f.btn4.BackColor = all[x +9].BackColor;
            }
            else if(x<=15)
            {
                f.btn2.BackColor = all[x + 2].BackColor;
                f.btn3.BackColor = all[x - 9].BackColor;
                f.btn4.BackColor = all[x - 7].BackColor;
            }
            else
            {

                f.btn2.BackColor = all[x - 16].BackColor;
                f.btn3.BackColor = all[x - 7].BackColor;
                f.btn4.BackColor = all[x -9].BackColor;
            }
            f.Show();


        }



        public Form1()
            
        {
            InitializeComponent();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btn17_Click(object sender, EventArgs e)
        {
            Button[] Gall ={ btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7,
                btn8,btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17 };

            Button b = (Button)sender;
            string[] arr = b.Name.Split('n');
            int x = int.Parse(arr[1]);

            if (MessageBox.Show("will you use 2 colors?                                         ", "number of colors", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                rule1(x);
            }

            else if (MessageBox.Show("will you use 3 colors?                                        ", "number of colors", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)

            {
                
               
                rule3(x);

              
            }

            else
            {
                rule4(x);

            }

        }
    }
}
