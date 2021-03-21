using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__1
{
    public partial class Form1 : Form
    {
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button>();
            buttons.AddRange(new Button[5] { button1, button2, button3, button4, button5 });
            button1.Click += button1_Click;
            button2.Click += button1_Click;
            button3.Click += button1_Click;
            button4.Click += button1_Click;
            button5.Click += button1_Click;

            void button1_Click(object sender, EventArgs e)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                Button btn = buttons[rnd.Next(buttons.Count)];
                btn.Visible = !btn.Visible;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Доброго времени суток!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("До новых встреч!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вам необходимо нажимать кнопки в таком порядке, чтоб в конечном итоге все они закрылись. Желаем удачи!");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}


        
  

