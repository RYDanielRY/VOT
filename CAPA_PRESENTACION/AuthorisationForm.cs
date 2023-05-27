using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp35.CAPA_DATOS;

namespace WindowsFormsApp35
{
    public partial class AuthorisationForm : Form
    {
        public AuthorisationForm()
        {
            InitializeComponent();
            CreateCaptcha(); 
        }

        public void CreateCaptcha()
        {
            Random random = new Random();
            int num = random.Next(6, 8);
            string captcha = "";
            int total = 0;
            do
            {
                int chr = random.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    total++;
                    if (total == num)
                        break;
                    {

                    }
                }
            } while (true);
            captchaImage.Text = captcha;
        }

        private void vojtiOrg_Click(object sender, EventArgs e)
        {
            if (captchaImage.Text == captchaBox.Text)
            {
                CD_Checkuser cD_Checkuser = new CD_Checkuser();
                cD_Checkuser.CheckRoleUser(textBox1.Text, textBox2.Text);
            }
            else
            {
                MessageBox.Show("Неверно введённые данные");
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
