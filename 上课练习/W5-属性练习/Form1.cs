using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5_属性练习
{
    public partial class Form1 : Form
    {
        public Student stu;
        public Farmer farmerOne;
        public Form1()
        {

            InitializeComponent();

            stu= new Student(1996);
            stu.display();

            farmerOne = new Farmer(10,20,numericUpDown_Cows,numericUpDown_FeedPrice, label_display);

            numericUpDown_FeedPrice.Value = 10;
            numericUpDown_Cows.Value = 10;

            farmerOne.Update();
            farmerOne.Display();
    }
        
        private void numericUpDown_Cows_ValueChanged(object sender, EventArgs e)
        {
            farmerOne.Update();
            farmerOne.Display();
        }

        private void numericUpDown_FeedPrice_ValueChanged(object sender, EventArgs e)
        {
            farmerOne.Update();
            farmerOne.Display();
        }
    }
    public class Farmer
    {
        private int numOfFeed;

        public Farmer(int _bagOfFed ,int _numberOfCows,NumericUpDown _NumbericUpDown, NumericUpDown _NumbericUpDown2, Label _Label)
        {
            numOfFeed = _bagOfFed;
            numberOfCows = _numberOfCows;
            myNumbericUpDown = _NumbericUpDown;
            myNumbericUpDown2 = _NumbericUpDown2;
            myLabel = _Label;
        }

        public int NumOfFeed
        {
            get { return numOfFeed; }
            set { numOfFeed = value; }
        }
        private int numberOfCows;

        public int NumberOfCows
        {
            get { return numberOfCows; }
            set {
                numberOfCows = value;
                NumOfFeed = numberOfCows * multiplyer;
            }
        }
        private int multiplyer = 15;
        public int Multiplyer
        {
            get { return multiplyer; }
            set { multiplyer = value; }
        }

        public NumericUpDown myNumbericUpDown;
        public NumericUpDown myNumbericUpDown2;
        public Label myLabel;

        public void Update()
        {
            NumberOfCows = (int)myNumbericUpDown.Value;
            Multiplyer = (int)myNumbericUpDown2.Value;
        }
        public void Display(){
            myLabel.Text = "the number of bags to feed is " + numOfFeed.ToString();
        }
    }
    public class Student
    {
        public Student(int _year)
        {
            birthDate = _year;
        }
        private int birthDate;
        public int Age
        {
            get { return DateTime.Now.Year - birthDate; }
            set { birthDate = value; }
        }
        public void display()
        {
            Console.WriteLine(Age);
        }

    }
}
