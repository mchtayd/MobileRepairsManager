using DataAccess.Abstract;
using DataAccess.Concreate;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class LoginManager //: IRepository<Login>
    {
        static LoginManager loginManager;
        LoginDal loginDal;

        private LoginManager()
        {
            loginDal = LoginDal.GetInstance();
        }

        public static LoginManager GetInstance()
        {
            if (loginManager == null)
            {
                loginManager = new LoginManager();
            }
            return loginManager;
        }

        public string Add(Login entity)
        {
            try
            {
                return loginDal.Add(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Login Get(string username, string password)
        {
            try
            {
                return loginDal.Get(username, password);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Login> GetList(string username)
        {
            try
            {
                return loginDal.GetList(username);
            }
            catch (Exception)
            {
                return new List<Login>();
            }
        }

        public string Update(Login entity)
        {
            throw new NotImplementedException();
        }
    }
}
