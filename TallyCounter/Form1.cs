using System.Resources;
using TallyCounter.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TallyCounter
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private Image hoverImage;
        private Image originalImage;
        private Image hoverImagePlus;
        private Image originalImagePlus;
        private Image hoverImageReset;
        private Image originalImageReset;

        public Form1()
        {
            InitializeComponent();
            labelCount.Text = count.ToString();
            hoverImage = Properties.Resources.hoverminus;
            originalImage = Properties.Resources.whitehoverminus;
            hoverImagePlus = Properties.Resources.hoverplus;
            originalImagePlus = Properties.Resources.whiteplus;
            hoverImageReset = Properties.Resources.hoverreset;
            originalImageReset = Properties.Resources.resetwhite;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            labelCount.Text = count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (count > 0)
            {
                count--;
                labelCount.Text = count.ToString();
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            count = 0;
            labelCount.Text = count.ToString();

        }

        private void button1_enter(object sender, EventArgs e)
        {
            button1.Image = hoverImage;
        }

        private void button1_leave(object sender, EventArgs e)
        {
            button1.Image = originalImage;
        }

        private void button2_enter(object sender, EventArgs e)
        {
            button2.Image = hoverImagePlus;
        }

        private void button2_leave(object sender, EventArgs e)
        {
            button2.Image = originalImagePlus;
        }

        private void button3_enter(object sender, EventArgs e)
        {
            button3.Image = hoverImageReset;
        }

        private void button3_leave(object sender, EventArgs e)
        {
            button3.Image = originalImageReset;
        }


        /*       private void button2_up(object sender, MouseEventArgs e)
               {
                   button2.FlatAppearance.MouseDownBackColor = Color.Black;
               }

               private void button1_up(object sender, MouseEventArgs e)
               {
                   button1.FlatAppearance.MouseDownBackColor = Color.Black;

               }

               private void button3_up(object sender, MouseEventArgs e)
               {
                   button3.FlatAppearance.MouseDownBackColor = Color.Black;

               }*/
    }

}