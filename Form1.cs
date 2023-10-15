using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        string result;
        bool prerequsiteClear;
        
        ArrayList textboxes;
        List<string> selected_subjects = new List<string>();

       
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Here i used the array which store the first name and last name
            textboxes=new ArrayList { textBox1.Text.Trim(), textBox2.Text.Trim() };

            string[] subjects = textBox3.Lines;
            selected_subjects.AddRange(subjects);

            result = "";

            prerequsiteClear = checkBox1.Checked;
            if(prerequsiteClear)
            {

                
                
               result += Environment.NewLine + "Personal Info :" + Environment.NewLine;
                result += $"First Name : {textboxes[0]}{Environment.NewLine}Last Name : {textboxes[1]}{Environment.NewLine}";




                



                if (selected_subjects.Count > 0)
                {
                    result += Environment.NewLine + "Entered Subjects :" + Environment.NewLine;
                    for (int i = 0; i < selected_subjects.Count; i++)
                    {
                        result += $"{i + 1} Subject: {selected_subjects[i]}{Environment.NewLine}";
                    }
                }


            }
            else
            {

                result = "Kindly Check the Pre Requsite Box ";
            }

           

            label5.Text = result;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add your code for handling the SelectedIndexChanged event here.
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
