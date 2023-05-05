using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prakt16_2
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(richTextBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string vvod = richTextBox1.Text;
            string[] array = vvod.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int digitCount = array.SelectMany(s => s).Count(char.IsDigit);
            richTextBox2.AppendText($"Цифр в массиве: {digitCount}\n\n");
            richTextBox2.AppendText("Элементы массива до символа \"/\":\n");
            foreach (string s in array.TakeWhile(s => s != "/"))
            {
                richTextBox2.AppendText(s + "\n");
            }
            richTextBox2.AppendText("\n");
            richTextBox2.AppendText("Элементы массива после символа \"/\" :\n");
            string[] newArray = array.SkipWhile(s => s != "/").Skip(1).Select(s => s.ToUpper() == s ? s.ToLower() : s.ToUpper()).ToArray();
            foreach (string s in newArray)
            {
                richTextBox2.AppendText(s + "\n");
            }
            File.WriteAllLines("info.txt", newArray);
           
        }
    }
}
