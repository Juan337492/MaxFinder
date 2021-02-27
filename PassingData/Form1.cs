using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassingData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void max()
        {

        }

        public int maxReturn(int num1, int num2 , int num3) {

            if ((num1 > num2) && (num1 > num3))
            {
                return num1;
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                return num2;
            }
            else {
                return num3;

            }

        }
        int answer;
        public void maxGlobal(int num1, int num2, int num3)
        {
            if ((num1 > num2) && (num1 > num3))
            {
                answer = num1;
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                answer = num2;
            }
            else
            {
                answer = num3;

            }
        }

        public void maxRef(int num1,int num2,int num3, ref int ans)
        {
            
            if ((num1 > num2) && (num1 > num3))
            {
                ans = num1;
               
            }
            else
                if ((num2 > num1) && (num2 > num3))
            {
                ans = num2;
                
            }
            else
                ans = num3;
            
        }

        private void ReturnValueBtn_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = Int32.Parse(num1TextBox.Text);
            num2 = Int32.Parse(num2TextBox.Text);
            num3 = Int32.Parse(num3Textbox.Text);

            int answ = maxReturn(num1,num2,num3);

            answerTextBox.Text = String.Format("{0:0.00}", answ);
        }

       
        private void GlobalDataBtn_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = Int32.Parse(num1TextBox.Text);
            num2 = Int32.Parse(num2TextBox.Text);
            num3 = Int32.Parse(num3Textbox.Text);
            maxGlobal(num1, num2, num3);
            answerTextBox.Text = String.Format("{0:0.00}", answer);
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            int ans = 0;
            num1 = Int32.Parse(num1TextBox.Text);

            num2 = Int32.Parse(num2TextBox.Text);

            num3 = Int32.Parse(num3Textbox.Text);

            maxRef(num1,num2,num3,ref ans);

            answerTextBox.Text = String.Format("{0:0.00}", ans);
        }
    }
}
