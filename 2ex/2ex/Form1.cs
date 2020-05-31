using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ex
{
    public partial class Form1 : Form
    {

        delegate void delegat();
        private delegat buttonClickEvent;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetOfActions_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Я супермегакнопка,\nі цього мене не позбавиш! ");
        }

        private void btn_Transparency_Click(object sender, EventArgs e)
        {
            buttonClickEvent = change_opacity;
            buttonClickEvent();
        }

        private void change_opacity()
        {
            this.Opacity = this.Opacity == 1 ? 0.70 : 1;
        }

        private void background_Click(object sender, EventArgs e)
        {
            buttonClickEvent = change_background;
            buttonClickEvent();
        }

        private void change_background()
        {
            this.BackColor = this.BackColor != Color.Yellow ? Color.Yellow : Color.Gray;
        }

        private void btn_text_Click(object sender, EventArgs e)
        {
            buttonClickEvent = text;
            buttonClickEvent();
        }
        private void text()
        {
            MessageBox.Show("World досі заблокований");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) btnSetOfActions.Click += OpacityEvent;
            else btnSetOfActions.Click -= OpacityEvent;
        }

        private void OpacityEvent(object sender, EventArgs e)
        {
            buttonClickEvent = change_opacity;
            buttonClickEvent();
        }


        //Поглинання кнопки "Колір тла"
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) btnSetOfActions.Click += ColorEvent;
            else btnSetOfActions.Click -= ColorEvent;
        }

        private void ColorEvent(object sender, EventArgs e)
        {
            buttonClickEvent = change_background;
            buttonClickEvent();
        }


        //поглинання кнопки Hello world
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) btnSetOfActions.Click += MessageEvent;
            else btnSetOfActions.Click -= MessageEvent;
        }

        private void MessageEvent(object sender, EventArgs e)
        {
            buttonClickEvent = text;
            buttonClickEvent();
        }
    }
}
