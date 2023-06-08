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
                    else if (textbox.Text == "")
                    {
                        textbox.Text = textbox.Tag.ToString();
                    }
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

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void tbUserLastName_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbUserLastName);
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Focus();
            }
        }

        private void tbUserFirstName_Click(object sender, EventArgs e)
        {

            RefreshTBNames(tbUserFirstName);
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Focus();
            }
        }

        private void tbUserBirthDate_Click(object sender, EventArgs e)
        {

            RefreshTBNames(tbUserBirthDate);
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Focus();
            }
        }

        private void tbUserAddress_Click(object sender, EventArgs e)
        {
            
            RefreshTBNames(tbUserAddress);
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Focus();
            }
        }

        private void tbUserCity_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbUserCity);
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Focus();
            }
        }

        private void tbDoctorLastName_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbDoctorLastName);
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Focus();
            }
        }

        private void tbDoctorFirstName_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbDoctorFirstName);
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Focus();
            }
        }

        private void tbDoctorBirthDate_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbDoctorBirthDate);
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Focus();
            }
        }

        private void tbDoctorAddress_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbDoctorAddress);
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Focus();
            }
        }

        private void tbDoctorCity_Click(object sender, EventArgs e)
        {
            RefreshTBNames(tbDoctorCity);
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Focus();
            }
        }
    }
}
