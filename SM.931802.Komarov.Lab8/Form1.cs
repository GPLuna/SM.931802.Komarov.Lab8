using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM._931802.Komarov.Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YNButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double a = r.NextDouble();
            if (a < 0.5)
            {
                LAnswer.Text = "Да";
            }
            else
            {
                LAnswer.Text = "Нет";
            }
        }

        private void BallButton_Click(object sender, EventArgs e)
        {
            string[] answers = { "Бесспорно", "Предрешено", "Мне кажется — «да»", "Вероятнее всего", "Спроси позже", "Сейчас нельзя предсказать", "Даже не думай", "Мой ответ — «нет»" };
            int S = answers.Length;
            double p = 1.0 / S;

            Random r = new Random();
            double A = r.NextDouble();
            int ans_id = -1;    
            do
            {
                A -= p;
                ans_id++;
            } while (A > 0);

            LAnswer.Text = answers[ans_id];
        }
    }
}
