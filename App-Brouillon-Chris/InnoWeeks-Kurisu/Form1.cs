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
    public partial class Form1 : Form
    {
        public List<TextBox> textBoxes = new List<TextBox>();
        public TextBox lastTextBox;

        public Form1()
        {
            InitializeComponent();
            SetTBTags();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SetTBTags()
        {
            foreach (TextBox textBox in GetAll(this, typeof(TextBox)))
            {
                textBoxes.Add(textBox);
                textBox.Tag = textBox.Text;
            }
        }
        public void RefreshTBNames(TextBox textbox)
        {
            for (int i = 0; i < textBoxes.Count; i++)
            {
                if (textbox == textBoxes[i])
                {
                    if (textbox.Text == textbox.Tag.ToString())
                    {
                        textbox.Text = "";
                    }
                }
            }
            if (lastTextBox != null)
            {
                if (lastTextBox.Text == "" && lastTextBox != null)
                {
                    lastTextBox.Text = lastTextBox.Tag.ToString();
                }
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

        private void tbUserLastName_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbUserLastName);
            lastTextBox = tbUserLastName;
        }

        private void tbUserFirstName_Click(object sender, EventArgs e)
        {

            RefreshTBNames(tbUserFirstName);
            lastTextBox = tbUserFirstName;
        }

        private void tbUserBirthDate_Click(object sender, EventArgs e)
        {

            RefreshTBNames(tbUserBirthDate);
            lastTextBox = tbUserBirthDate;
        }

        private void tbUserAddress_Click(object sender, EventArgs e)
        {
            
            RefreshTBNames(tbUserAddress);
            lastTextBox = tbUserAddress;
        }

        private void tbUserCity_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbUserCity);
            lastTextBox = tbUserCity;
        }

        private void tbDoctorLastName_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbDoctorLastName);
            lastTextBox = tbDoctorLastName;
        }

        private void tbDoctorFirstName_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbDoctorFirstName);
            lastTextBox = tbDoctorFirstName;
        }

        private void tbDoctorBirthDate_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbDoctorBirthDate);
            lastTextBox = tbDoctorBirthDate;
        }

        private void tbDoctorAddress_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbDoctorAddress);
            lastTextBox = tbDoctorAddress;
        }

        private void tbDoctorCity_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbDoctorCity);
            lastTextBox = tbDoctorCity;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach(TextBox textBox in GetAll(this, typeof(TextBox)))
            {
                if(textBox.Text == textBox.Tag.ToString())
                {
                    MessageBox.Show("Veuillez entrer toutes les informations");
                    break;
                }
                else 
                {
                    //create an instance of form 3
                    var form2 = new Form2();
                    //hide me (form1)
                    Hide();
                    //show form2
                    form2.Show();
                    //close me (form1), since form1 is the message loop - no problem.
                    Close();
                    break;
                }
            }
        }
    }
}
