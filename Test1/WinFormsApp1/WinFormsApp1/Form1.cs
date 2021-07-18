using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> s = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                s.Add(i.ToString());
            }
            PrintEnumerable(s);


        }

        void PrintEnumerable(System.Collections.IEnumerable enumerable)
        {
            textBox1.Text = "";
            StringBuilder sb = new StringBuilder();
            
            foreach (var value in enumerable)
            {
                sb.Append(value);
                sb.Append(Environment.NewLine);    
            }
            textBox1.Text = sb.ToString();

        }


        void PrintEnumerator(System.Collections.IEnumerator enumerator)
        {
            textBox1.Text = "";
            StringBuilder sb = new StringBuilder();

            while (enumerator.MoveNext())
            {
                sb.Append(enumerator.Current);
                sb.Append(Environment.NewLine);
            }
            textBox1.Text = sb.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                s.Add(i.ToString());
            }
            PrintEnumerator(s);

        }
    }
}
