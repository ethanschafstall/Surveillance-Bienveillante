using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnoWeeks_Kurisu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(Button button in GetAll(this, typeof(Button)))
            {
                button.BackColor = Color.Gainsboro;
            }
        }        

        /// <summary>
        /// Method to Get all controls of one type
        /// </summary>
        /// <param name="control"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool isOneButtonSelected = false;
            foreach (Button button in GetAll(this, typeof(Button)))
            {
                if (button.BackColor == Color.LightGreen)
                {
                    isOneButtonSelected = true;
                    break;
                }                
            }
            if(isOneButtonSelected == true)
            {
                //create an instance of form 3
                var form3 = new Form3();
                //hide me (form1)
                Hide();
                //show form2
                form3.Show();
                //close me (form1), since form1 is the message loop - no problem.
                Close();
            }
            if (isOneButtonSelected == false)
            {
                MessageBox.Show("Veuillez en selectionner au moins 1");
            }
        }

        private void ChangeBTNColorWhenSelected(Button button)
        {
            if(button.BackColor == Color.Gainsboro)
            {
                button.BackColor = Color.LightGreen;
            }
            else if(button.BackColor == Color.LightGreen)
            {
                button.BackColor = Color.Gainsboro;
            }                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button15);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button21);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button20);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button19);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button18);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button17);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ChangeBTNColorWhenSelected(button16);
        }
    }
}
