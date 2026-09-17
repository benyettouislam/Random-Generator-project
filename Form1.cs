using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Generato_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum enSize
        {
            CapitalLetter = 1, SmallLetter = 2
        }


        enum enStatus
        {
            Letters = 1, Numbers = 2, SpecialCharacter = 3, Mix = 4
        };


        enSize size;
        enStatus status;
        Random random = new Random();
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color black = Color.Black;
            Pen pen = new Pen(black);
            pen.Width = 10;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 200, 130, 400, 130);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblresult.Text = string.Empty;
            status = enStatus.Letters;
            size = enSize.CapitalLetter;
            rdleters.Checked = true;
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown1.Minimum;
            lblresult.Text = string.Empty;
            rdleters.Checked = true;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            size = enSize.CapitalLetter;

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            size = enSize.SmallLetter;

        }
        private string RandomChar(enStatus status,enSize size)
        {
            string s = "";
            int Number = 0;
            switch (status)
            {
                case enStatus.SpecialCharacter:
                    Number = random.Next(33, 48);
                    s = ((char)Number).ToString();
                    break;
                case enStatus.Numbers:
                    Number = random.Next(0, 10);
                    s = Convert.ToString(Number);
                    break;
                case enStatus.Letters:
                    switch (size)
                    {
                        case enSize.CapitalLetter:
                            Number = random.Next(65, 91);
                            s = ((char)Number).ToString();
                            break;
                        case enSize.SmallLetter:
                            Number = random.Next(97, 123);
                            s = ((char)Number).ToString();
                            break;
                    }
                    break;
            }



            return s;

        }
        private void Generate()
        {
            string s = "";
            if (status == enStatus.Mix)
            {
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    int Number = random.Next(1, 4);
                   enStatus status2 = (enStatus)Number;
                    if (status2 == enStatus.Letters)
                    {
                        Number = random.Next(1, 3);
                         size2 = (enSize)Number;
                        
                    }
                    s += RandomChar(status2, size2);
                }
            }
            else
            {
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    s += RandomChar(status,size);
                }
            }


        
        lblresult.Text = s;
        } 
        private void btngenrate_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void rdleters_CheckedChanged(object sender, EventArgs e)
        {
            status=enStatus.Letters;
        }

        private void rdspecialcharchter_CheckedChanged(object sender, EventArgs e)
        {
            status=enStatus.SpecialCharacter;
        }

        private void rdNumbers_CheckedChanged(object sender, EventArgs e)
        {
            status = enStatus.Numbers;
        }

        private void rdMix_CheckedChanged(object sender, EventArgs e)
        {
            status= enStatus.Mix;
        }
    } 
}
