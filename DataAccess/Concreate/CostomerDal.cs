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
    public class CostomerDal //: IRepository<Costomer>
    {
        static CostomerDal costomerDal;
        SqlServices sqlServices;
        SqlDataReader dataReader;

        private CostomerDal()
        {
            sqlServices = SqlDatabase.GetInstance();
        }
        public static CostomerDal GetInstance()
        {
            if (costomerDal == null)
            {
                costomerDal = new CostomerDal();
            }
            return costomerDal;
        }

        public string Add(Costomer entity)
        {
            try
            {
                dataReader = sqlServices.StoreReader("CostomerAdd",
                    new SqlParameter("@name",entity.Name),
                    new SqlParameter("@phone",entity.Phone),
                    new SqlParameter("@adress",entity.Adress));

                dataReader.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                sqlServices.Stored("CostomerDelete", new SqlParameter("@id", id));
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Costomer Get(int id)
        {
            try
            {
                dataReader = sqlServices.StoreReader("CostomerList", new SqlParameter("@id", id));
                Costomer item = null;
                while (dataReader.Read())
                {
                    item = new Costomer(
                        dataReader["Id"].ConInt(),
                        dataReader["NAME"].ToString(),
                        dataReader["PHONE"].ToString(),
                        dataReader["ADRESS"].ToString()); 
                }
                dataReader.Close();
                return item;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Costomer> GetList()
        {
            try
            {
                List<Costomer> costomers = new List<Costomer>();
                dataReader = sqlServices.StoreReader("CostomerList");
                while (dataReader.Read())
                {
                    costomers.Add(new Costomer(
                        dataReader["Id"].ConInt(),
                        dataReader["NAME"].ToString(),
                        dataReader["PHONE"].ToString(),
                        dataReader["ADRESS"].ToString()));
                }
                dataReader.Close();
                return costomers;
            }
            catch (Exception)
            {
                return new List<Costomer>();
            }
        }

        public string Update(Costomer entity)
        {
            try
            {
                dataReader = sqlServices.StoreReader("CostomerUpdate",
                    new SqlParameter("@id",entity.Id),
                    new SqlParameter("@name",entity.Name),
                    new SqlParameter("@phone",entity.Phone),
                    new SqlParameter("@adress",entity.Adress));

                dataReader.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
