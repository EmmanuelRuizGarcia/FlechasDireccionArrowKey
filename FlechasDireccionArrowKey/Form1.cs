using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlechasDireccionArrowKey
{
    public partial class Form1 : Form
    {
        string nameOfControl = string.Empty;
        int numberOfTapIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var campos = new string[]
            {
                "textBox1",
                "textBox2",
                "textBox3"
            };

            if (campos.Contains(nameOfControl))
            {
                var contenido = string.Empty;
                Control anterior;

                if (e.KeyData.Equals(Keys.Left))
                {
                    if (!string.IsNullOrWhiteSpace(nameOfControl))
                    {
                        if (nameOfControl.Equals("textBox3"))
                        {
                            contenido = textBox3.Text;
                            textBox2.Text = contenido;
                            textBox3.Clear();
                            anterior = GetNextControl(textBox3, false);
                            anterior.Focus();
                            textBox2.SelectAll();
                        }
                        else if (nameOfControl.Equals("textBox2"))
                        {
                            contenido = textBox2.Text;
                            textBox1.Text = contenido;
                            textBox2.Clear();
                            anterior = GetNextControl(textBox2, false);
                            anterior.Focus();
                            textBox1.SelectAll();
                        }
                    }
                }
                else if (e.KeyData.Equals(Keys.Right))
                {
                    if (!string.IsNullOrWhiteSpace(nameOfControl))
                    {
                        if (nameOfControl.Equals("textBox1"))
                        {
                            contenido = textBox1.Text;
                            textBox2.Text = contenido;
                            textBox1.Clear();
                            anterior = GetNextControl(textBox1, true);
                            anterior.Focus();
                            textBox2.SelectAll();
                        }
                        else if (nameOfControl.Equals("textBox2"))
                        {
                            contenido = textBox2.Text;
                            textBox3.Text = contenido;
                            textBox2.Clear();
                            anterior = GetNextControl(textBox2, true);
                            anterior.Focus();
                            textBox3.SelectAll();
                        }
                    }
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            nameOfControl = textBox1.Name.ToString();
            numberOfTapIndex = textBox1.TabIndex;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            nameOfControl = textBox2.Name.ToString();
            numberOfTapIndex = textBox2.TabIndex;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            nameOfControl = textBox3.Name.ToString();
            numberOfTapIndex = textBox3.TabIndex;
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            nameOfControl = button1.Name.ToString();
            numberOfTapIndex = button1.TabIndex;
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            nameOfControl = button2.Name.ToString();
            numberOfTapIndex = button2.TabIndex;
        }
    }
}
