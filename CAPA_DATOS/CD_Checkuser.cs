using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp35.CAPA_CONNECTION;
using WindowsFormsApp35.CAPA_PRESENTACION;

namespace WindowsFormsApp35.CAPA_DATOS
{
    public class CD_Checkuser
    {
        public CD_Connection connection = new CD_Connection();
        public SqlCommand command = new SqlCommand();
        public SqlDataReader reader;

        public void CheckRoleUser(string uname, string upass)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "CheckUse";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Email", uname);
            command.Parameters.AddWithValue("@Password", upass);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int readers3 = reader[3].ToString().Length;
                int readers4 = reader[4].ToString().Length;
                int readers5 = reader[5].ToString().Length;
                int readers6 = reader[6].ToString().Length;
                if (readers3 == 1 && readers4 == 0 && readers5 == 0 && readers6 == 0)
                {
                    JuryForm juryForm = new JuryForm();
                    juryForm.ShowDialog();
                }
                else if (readers3 == 0 && readers4 == 1 && readers5 == 0 && readers6 == 0)
                {
                    ModeratoryForm moderatoryForm = new ModeratoryForm();
                    moderatoryForm.ShowDialog();
                }
                else if (readers3 == 0 && readers4 == 0 && readers5 == 1 && readers6 == 0)
                {
                    GroupsWatchForm organisatorForm = new GroupsWatchForm();
                    organisatorForm.ShowDialog();
                }
                else if (readers3 == 0 && readers4 == 0 && readers5 == 0 && readers6 == 1)
                {
                    MembersForm membersForm = new MembersForm();
                    membersForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
