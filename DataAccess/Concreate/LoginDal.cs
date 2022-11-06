using DataAccess.Abstract;
using DataAccess.Database;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class LoginDal //: IRepository<Login>
    {
        static LoginDal loginDal;
        SqlServices sqlServices;
        SqlDataReader dataReader;

        private LoginDal()
        {
            sqlServices = SqlDatabase.GetInstance();
        }
        
        public static LoginDal GetInstance()
        {
            if (loginDal == null)
            {
                loginDal = new LoginDal();
            }
            return loginDal;
        }

        public string Add(Login entity)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Login Get(string username,string password)
        {
            try
            {
                dataReader = sqlServices.StoreReader("LoginList",new SqlParameter("@username", username),new SqlParameter("@password", password));
                Login item = null;
                while (dataReader.Read())
                {
                    item = new Login(dataReader["ID"].ConInt(), dataReader["USERNAME"].ToString(), dataReader["PASSWORD"].ToString());
                }
                dataReader.Close();
                return item;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Login> GetList()
        {
            throw new NotImplementedException();
        }

        public string Update(Login entity)
        {
            throw new NotImplementedException();
        }
    }
}
