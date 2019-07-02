using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add_element_lit_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numbers = new List<int>();
       


        private void AddButton_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(inputTextBox.Text);

            numbers.Add(input);


            

            showRichTextBox.Text = Display();

            inputTextBox.Clear();
           

        }

        private String Display()
        {
            string message = "";

            int index = 0;

            foreach (int number in numbers)
            {
                message = message + "Index Number\t" + index + "\tnumber\t" + number + "\n";
                index++;
            }
            return message;
        }
        private void SumButton_Click(object sender, EventArgs e)
        {
            int sum=0;

            string message = "";


            foreach (int number in numbers)
            {
                sum = sum + number;

                message ="\nSummation\t" + sum;
            }
          
            showRichTextBox.Text = message;
        }

       

        private void reverseButton_Click(object sender, EventArgs e)
        {
           string message = "";
            foreach (int number in numbers)
            {
                message = message + "\n Given value \t" + number + "\n";
            }


            //numbers.Reverse();

            //foreach (int number in numbers)
            //{
            //    message = message + "\nrevers value \t" + number + "\n";
            //}


            for (int index = numbers.Count - 1; index >=0 ; index--)


            {
               message = message +"\nrevers value\t "+ numbers[index]+ "\n";
            }


         

            showRichTextBox.Text = message;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            string message = " \t Copy list\n";

            foreach (int number in numbers)
            {
                message = message + " " + number+"\n";
            }
            showRichTextBox.Text = message;
        }



        private void DupButton_Click(object sender, EventArgs e)
        {
            string message = "";
            int count = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 1; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] == numbers[j + 1])
                    {
                        count = count + 1;
                      
                    }

                }
                message = " Duplicate Number\t\t:" + count + "\n";

            }
            showRichTextBox.Text = message;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            string messgae = "\tSort List\n";

            numbers.Sort();
            foreach (int number in numbers)
            {
                messgae = messgae + number + "\n";
            }

            showRichTextBox.Text = messgae;

        }

        private void UniqueButton_Click(object sender, EventArgs e)
        {
            string message = "";
            int count = 1;
            for(int i = 0; i < numbers.Count; i++)
            {
                for (int j = 1; j < numbers.Count-1; j++)
                {
                    if (numbers[j] != numbers[j+1])
                    {
                        count = count + 1;
                      
                    }
                }
                message =  " Unique Number\t\t" + count + "\n";

            }

            showRichTextBox.Text = message;

        }

        private void ascendingButton_Click(object sender, EventArgs e)
        {
            string message = "";
            string message1 = "";
            numbers.Sort();

            foreach (int number in numbers)
            {
                message = message + number+",";

            }


           
            numbers.Reverse();
            foreach (int number in numbers)
            {
                message1 = message1 + number+",";

            }
            showRichTextBox.Text = Display() + "\n\n Ascedinding Number\n" + message  + "\n\nDcending Number\n" + message1;

        }

        private void maxButton_Click(object sender, EventArgs e)
        {

            string message = "";

            showRichTextBox.Text = message + Display()+"\n" + "Maximum Number\t "+ numbers.Max()+ "\n" +"Minimun Number\t" + numbers.Min();
           


        }

        private void oddButton_Click(object sender, EventArgs e)
        {

            string message = "";
            string message1 = "";
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    message = message + number+","; 
                }

                
            }
           foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    message1 = message1 + number + ",";
                }
              

            }
            showRichTextBox.Text = Display() +"\n\n"+ "Even Number : \t" + message +"\n" + "Odd Number : \t" + message1;
        }

        private void newValueButton_Click(object sender, EventArgs e)
        {
        //    string message = "";
        //    numbers.Insert(input,new numbers());
          
        }

        private void AvarageButton_Click(object sender, EventArgs e)
        {
            string message = "";
            int sum = 0;
           
                sum = numbers.Sum() / numbers.Count();
                message = message + sum;
            
            showRichTextBox.Text = Display()+"\n\n AVARAGE VALUE\t\t:"+message;
        }
    }
}
