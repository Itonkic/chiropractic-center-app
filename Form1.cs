using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Layout.Properties;
using iText.IO.Image;
using Image = iText.Layout.Element.Image;
using iText.Kernel.Pdf.Filespec;

namespace Projektki
{

    public partial class Form1 : Form
    {

    public Form1()
        {
            InitializeComponent();
                        textBox2.ForeColor = System.Drawing.Color.Black;

            textBox2.PasswordChar = '●';
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FizioCentarKopett f3 = new FizioCentarKopett();

            // f3.ShowDialog();
            if ((textBox1.Text == "kiki") && (textBox2.Text == "1111"))
            {
                //this.Hide();
                FizioCentarKopett f2 = new FizioCentarKopett();
                f2.ShowDialog();
            }
            else
                MessageBox.Show("Pogrešan Username/Password");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

    }
}