using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp35.CAPA_PRESENTACION
{
    public partial class GroupsWatchForm : Form
    {
        public GroupsWatchForm()
        {
            InitializeComponent();
            TimeUtro(); 
        }

        public void TimeUtro()
        {
            label1.Visible = false; 
            DateTime dateTime = DateTime.Now;
            label1.Text = dateTime.ToShortTimeString();
            int a = label1.Text.Length;
            int b = 9;
            if (a > b && a < 11)
            {
                label2.Text = "Доброе утро";
            }
            else if (a >= 11 && a < 18)
            {
                label2.Text = "Добрый день";
            }
            else if (a >= 18 && a < 00)
            {
                label2.Text = "Добрый вечер";
            }
            else if (a >= 00 && a < 08)
            {
                label2.Text = "Доброй ночи"; //Введено с целью проверки работоспособности данной функции
            }
        }

        private void createJury_Click(object sender, EventArgs e)
        {
            CreateJury createJury = new CreateJury();
            createJury.Show(); 
        }

        private void createModers_Click(object sender, EventArgs e)
        {
            CreateModers createModers = new CreateModers(); 
            createModers.Show(); 
        }

        private void WatchMyProfile_Click(object sender, EventArgs e)
        {
            WatchMyProfile watchMyProfile = new WatchMyProfile();
            watchMyProfile.Show(); 
        }
    }
}
