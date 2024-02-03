using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class Calculator : Form
    {
        private Rectangle btnoneOriginalRectangle;
        private Rectangle btntwoOriginalRectangle;
        private Rectangle btnthreeOriginalRectangle;
        private Rectangle btnfourOriginalRectangle;
        private Rectangle btnfiveOriginalRectangle;
        private Rectangle btnsixOriginalRectangle;
        private Rectangle btnsevenOriginalRectangle;
        private Rectangle btneightOriginalRectangle;
        private Rectangle btnnineOriginalRectangle;
        private Rectangle btnZeroOriginalRectangle;
        private Rectangle btnbackspaceOriginalRectangle;
        private Rectangle plsminusbtnOriginalRectangle;
        private Rectangle btnclearOriginalRectangle;
        private Rectangle btnDecimalOriginalRectangle;
        private Rectangle btnsqrtOriginalRectangle;
        private Rectangle btnmultiplyOriginalRectangle;
        private Rectangle btndvideOriginalRectangle;
        private Rectangle btnminusOriginalRectangle;
        private Rectangle btnequalOriginalRectangle;
        private Rectangle btnplusOriginalRectangle;
        private Rectangle displayLabelOriginalRectangle;
        private Size originalFormSize;
        //todo cretae the rectangle variables in the load


        public Calculator()
        {
            InitializeComponent();
           KeyPreview = true;
            
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            btnoneOriginalRectangle = new Rectangle(btnone.Location.X,btnone.Location.Y,btnone.Width,btnone.Height);
            btntwoOriginalRectangle = new Rectangle(btntwo.Location.X,btntwo.Location.Y,btntwo.Width,btntwo.Height);
            btnthreeOriginalRectangle = new Rectangle(btnthree.Location.X,btnthree.Location.Y,btnthree.Width,btnthree.Height);
            btnfourOriginalRectangle = new Rectangle(btnfour.Location.X,btnfour.Location.Y,btnfour.Width,btnfour.Height);
            btnfiveOriginalRectangle = new Rectangle(btnfive.Location.X,btnfive.Location.Y, btnfive.Width,btnfive.Height);
            btnsixOriginalRectangle = new Rectangle(btnsix.Location.X,btnsix.Location.Y,btnsix.Width,btnsix.Height);
            btnsevenOriginalRectangle = new Rectangle(btnseven.Location.X,btnseven.Location.Y,btnseven.Width,btnseven.Height);
            btneightOriginalRectangle = new Rectangle(btneight.Location.X,btneight.Location.Y,btneight.Width,btneight.Height);
            btnnineOriginalRectangle = new Rectangle(btnnine.Location.X,btnnine.Location.Y,btnnine.Width,btnnine.Height);
            btnZeroOriginalRectangle = new Rectangle(btnZero.Location.X,btnZero.Location.Y,btnZero.Width,btnZero.Height);
            btnbackspaceOriginalRectangle = new Rectangle(btnbackspace.Location.X, btnbackspace.Location.Y,btnbackspace.Width,btnbackspace.Height);
            plsminusbtnOriginalRectangle = new Rectangle(PlsMnsbutton.Location.X, PlsMnsbutton.Location.Y, PlsMnsbutton.Width, PlsMnsbutton.Height);
            btnclearOriginalRectangle = new Rectangle(btnclear.Location.X, btnclear.Location.Y, btnclear.Width, btnclear.Height);
            btnDecimalOriginalRectangle = new Rectangle(btnDecimal.Location.X,btnDecimal.Location.Y,btnDecimal.Width,btnDecimal.Height);
            btnsqrtOriginalRectangle = new Rectangle(btnsqrt.Location.X,btnsqrt.Location.Y,btnsqrt.Width,btnsqrt.Height);
            btnmultiplyOriginalRectangle = new Rectangle(btnmultiply.Location.X,btnmultiply.Location.Y,btnmultiply.Width,btnmultiply.Height);
            btndvideOriginalRectangle = new Rectangle(btndvide.Location.X,btndvide.Location.Y,btndvide.Width,btndvide.Height);
            btnminusOriginalRectangle = new Rectangle(btnminus.Location.X,btnminus.Location.Y,btnminus.Width,btnminus.Height);
            btnequalOriginalRectangle = new Rectangle(btnequal.Location.X,btnequal.Location.Y,btnequal.Width,btnequal.Height);
            btnplusOriginalRectangle = new Rectangle(btnplus.Location.X,btnplus.Location.Y,btnplus.Width,btnplus.Height);
            displayLabelOriginalRectangle = new Rectangle(displayLabel.Location.X,displayLabel.Location.Y,displayLabel.Width,displayLabel.Height);
            

        }
      



        private void Calculator_Resize(object sender, EventArgs e)
        {
            resizeControl(btnoneOriginalRectangle, btnone);
            resizeControl(btntwoOriginalRectangle, btntwo);
            resizeControl(btnthreeOriginalRectangle, btnthree);
            resizeControl(btnfourOriginalRectangle, btnfour);
            resizeControl(btnfiveOriginalRectangle, btnfive);
            resizeControl(btnsixOriginalRectangle, btnsix);
            resizeControl(btnsevenOriginalRectangle, btnseven);
            resizeControl(btneightOriginalRectangle, btneight);
            resizeControl(btnnineOriginalRectangle, btnnine);
            resizeControl(btnZeroOriginalRectangle, btnZero);
            resizeControl(btnbackspaceOriginalRectangle, btnbackspace);
            resizeControl(plsminusbtnOriginalRectangle, PlsMnsbutton);
            resizeControl(btnclearOriginalRectangle, btnclear);
            resizeControl(btnDecimalOriginalRectangle, btnDecimal);
            resizeControl(btnsqrtOriginalRectangle, btnsqrt);
            resizeControl(btnmultiplyOriginalRectangle, btnmultiply);
            resizeControl(btndvideOriginalRectangle, btndvide);
            resizeControl(btnminusOriginalRectangle, btnminus);
            resizeControl(btnequalOriginalRectangle, btnequal);
            resizeControl(btnplusOriginalRectangle, btnplus);
            resizeControl(displayLabelOriginalRectangle, displayLabel);

        }

        private void resizeControl(Rectangle OriginalControlRect,Control control)
        {
            float xAxis = (float)(this.Width) / (float)(originalFormSize.Width);
            float yAxis = (float)(this.Height) / (float)(originalFormSize.Height);
            //getting the new postion
            int newXPosition = (int)(OriginalControlRect.X * xAxis);
            int newYPosition = (int)(OriginalControlRect.Y * yAxis);
            

            //new standarts
            int newWidth = (int)(OriginalControlRect.Width * xAxis);
            int newHeight = (int)(OriginalControlRect.Height * yAxis);

            //settings here
            control.Location = new Point(newXPosition,newYPosition);
            control.Size = new Size(newWidth, newHeight);

        }

        float num1, num2, result;
        char operation;
        bool dec = false;

        private void changeLabel(int numPressed)
        {
            if (dec == true)
            {
                //if thenumber is decimal
                int decimalCount = 0;
                foreach(char c in displayLabel.Text)
                {

                    if(c == '.')
                    {
                        decimalCount++;
                    }
                }
                if(decimalCount < 1)
                {
                    displayLabel.Text = displayLabel.Text + ".";
                }
                dec = false;

            }
            else
            {
                if(displayLabel.Text.Equals("0")  == true && displayLabel.Text != null)
                {
                    displayLabel.Text = numPressed.ToString();

                }
                else if (displayLabel.Text.Equals("-0") == true)
                {
                    displayLabel.Text = "-" + numPressed.ToString();
                }
                else
                {
                 displayLabel.Text = displayLabel.Text + numPressed.ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            result = 0;
            if (displayLabel.Text.Equals("0") == false)
            {
                switch (operation)
                {
                    //for every operation we create an case and if not any of this trigerred 
                    //then it proceeds with the default in order to protect code integrity and this allows code not to break
                    case '+':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 + num2;
                        break;
                    case '-':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 - num2;
                        break;
                    case '*':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 * num2;
                        break;
                    case '/':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 / num2;
                        break;
                    default: 
                        break;
                }       
            }
            //to show the output of operation right here
            displayLabel.Text = result.ToString();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '+';
            result = result + num1;
            displayLabel.Text = "";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '-';
            result = result - num1;
            displayLabel.Text = "";
        }

        private void btndvide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '/';
            result = result / num1;
            displayLabel.Text = "";
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '*';
            result = result * num1;
            displayLabel.Text = "";

        }

        private void PlsMnsbutton_Click(object sender, EventArgs e)
        {
            //plsmns button right here
            displayLabel.Text = "-" + displayLabel.Text;
        }

        private void btnbackspace_Click(object sender, EventArgs e)
        {
            int stringLenght = displayLabel.Text.Length;
            if (stringLenght > 1)
            {
                displayLabel.Text = displayLabel.Text.Substring(0,stringLenght - 1);

            }
            else
            {
                displayLabel.Text = "0";
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
            num1 = 0; num2 = 0;
            result = 0;
            operation = '\0';
            dec = false;
        }
  
          
        private void btnsqrt_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            //adressin if the number is less than 0 or not
            if(num1 > 0)
            {
                double sqrt = Math.Sqrt(num1);
                displayLabel.Text = sqrt.ToString();
            }
        }

        private void Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            //key up
            switch (e.KeyCode)
            {
             case Keys.Enter:
                    btnequal.PerformClick();
                    break;
                default:
                     break;
            }

        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    btnone.PerformClick();
                    break;
                case Keys.NumPad2:
                 btntwo.PerformClick();
                    break;
                case Keys.NumPad3:
                    btnthree.PerformClick();
                    break;
                case Keys.NumPad4:
                    btnfour.PerformClick();
                    break;
                case Keys.NumPad5:
                    btnfive.PerformClick();
                    break;
                case Keys.NumPad6:
                    btnsix.PerformClick();
                    break;
                case Keys.NumPad7:
                    btnseven.PerformClick();
                    break;
                case Keys.NumPad8:
                    btneight.PerformClick();
                    break;
                case Keys.NumPad9:
                    btnnine.PerformClick();
                    break;
                case Keys.Divide:
                    btndvide.PerformClick();
                    break;
                case Keys.Multiply: 
                    btnmultiply.PerformClick(); 
                    break;
                case Keys.Subtract:
                    btnminus.PerformClick();
                    break;
                case Keys.Add:
                    btnplus.PerformClick();
                    break;
                default: 
                    break;


            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLabel(0);
        }

        private void displayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
