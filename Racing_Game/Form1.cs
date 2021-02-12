using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int firsthorsedistance, secondhorsedistance, thirdhorsedistance;    //distance to the left
        public int counter = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void btnStartingPosition_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            counter = 0;
            label7.Text = "0";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter = Convert.ToInt32(label7.Text);
            counter++;
            label7.Text = counter.ToString();

            int firsthoursewidth = pictureBox1.Width;
            int secondhorsewidth = pictureBox2.Width;
            int thirdhorsewidth = pictureBox3.Width;
            int finishingline = label5.Left;

            Random random = new Random();
            pictureBox1.Left = pictureBox1.Left + random.Next(3, 25);
            pictureBox2.Left = pictureBox2.Left + random.Next(3, 25);
            pictureBox3.Left = pictureBox3.Left + random.Next(3, 25);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "The horse number '1' is front-running...";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "The horse number '2' getting on a sudden sprint...";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "The horse number '3' keep the leading position...";
            }

            if (firsthoursewidth + pictureBox1.Left >= finishingline)
            {
                timer1.Enabled = false;

                if (secondhorsewidth + pictureBox2.Left >= thirdhorsewidth + pictureBox3.Left)
                {
                    label6.Text = "- OMG, The horse number '1' won !!!" +
                                  "\n- The horse number '2' is runner up" +
                                  "\n- The horse number '3' is come in third in the race";
                }
                if (thirdhorsewidth + pictureBox3.Left >= secondhorsewidth + pictureBox2.Left)
                {
                    label6.Text = "- OMG, The horse number '1' won !!!" +
                                  "\n- The horse number '3' is runner up" +
                                  "\n- The horse number '2' is come in third in the race";
                }
            }
            if (secondhorsewidth + pictureBox2.Left >= finishingline)
            {
                timer1.Enabled = false;

                if (firsthoursewidth + pictureBox1.Left >= thirdhorsewidth + pictureBox3.Left)
                {
                    label6.Text = "- OMG, The horse number '2' won !!!" +
                                  "\n- The horse number '1' is runner up" +
                                  "\n- The horse number '3' is come in third in the race";
                }
                if (thirdhorsewidth + pictureBox3.Left >= firsthoursewidth + pictureBox1.Left)
                {
                    label6.Text = "- OMG, The horse number '2' won !!!" +
                                  "\n- The horse number '3' is runner up" +
                                  "\n- The horse number '1' is come in third in the race";
                }
            }
            if (thirdhorsewidth + pictureBox3.Left >= finishingline)
            {
                timer1.Enabled = false;

                if (firsthoursewidth + pictureBox1.Left >= secondhorsewidth + pictureBox2.Left)
                {
                    label6.Text = "- OMG, The horse number '3' won !!!" +
                                  "\n- The horse number '1' is runner up" +
                                  "\n- The horse number '2' is come in third in the race";
                }
                if (secondhorsewidth + pictureBox2.Left >= firsthoursewidth + pictureBox1.Left)
                {
                    label6.Text = "- OMG, The horse number '3' won !!!" +
                                  "\n- The horse number '2' is runner up" +
                                  "\n- The horse number '1' is come in third in the race";
                }
            }
        }   
        private void Form1_Load(object sender, EventArgs e)
        {
            firsthorsedistance = pictureBox1.Left;
            secondhorsedistance = pictureBox2.Left;
            thirdhorsedistance = pictureBox3.Left;
        }
    }
}
