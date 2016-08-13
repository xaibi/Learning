using BussinessObject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositries.Repostry
{
    public class UserRepos :  ConnectionManager
    {
        private SqlCommand command;

        public bool AddUser(User user)
        {
            try
            {
                base.Open();
                command = new SqlCommand("AddUser", base.conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.NVarChar)).Value = user.Name;
                command.ExecuteNonQuery();
                return true;


            }
            catch
            {
                return false;
            }
            finally
            {
                base.Close();
            }


        }
    }
}
