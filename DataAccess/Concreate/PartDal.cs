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
    public class PartDal // : IRepository<Part>
    {
        static PartDal partDal;
        SqlServices sqlServices;
        SqlDataReader dataReader;

        private PartDal()
        {
            sqlServices = SqlDatabase.GetInstance();
        }
        public static PartDal GetInstance()
        {
            if (partDal == null)
            {
                partDal = new PartDal();
            }
            return partDal;
        }

        public string Add(Part entity)
        {
            try
            {
                dataReader = sqlServices.StoreReader("PartAdd",
                    new SqlParameter("@name", entity.Name),
                    new SqlParameter("@cost", entity.Cost));

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
                sqlServices.Stored("PartDelete", new SqlParameter("@id", id));
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Part Get(int id)
        {
            try
            {
                dataReader = sqlServices.StoreReader("PartGetList", new SqlParameter("@id", id));
                Part item = null;
                while (dataReader.Read())
                {
                    item = new Part(
                        dataReader["ID"].ConInt(),
                        dataReader["PART_NAME"].ToString(),
                        dataReader["PART_COST"].ConInt());
                }
                dataReader.Close();
                return item;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Part> GetList()
        {
            try
            {
                List<Part> parts = new List<Part>();
                dataReader = sqlServices.StoreReader("[PartGetList]");
                while (dataReader.Read())
                {
                    parts.Add(new Part(
                        dataReader["ID"].ConInt(),
                        dataReader["PART_NAME"].ToString(),
                        dataReader["PART_COST"].ConInt()));
                }
                dataReader.Close();
                return parts;

            }
            catch (Exception)
            {
                return new List<Part>();
            }
        }

        public string Update(Part entity)
        {
            try
            {
                dataReader = sqlServices.StoreReader("PartUpdate",
                    new SqlParameter("@id", entity.Id),
                    new SqlParameter("@name", entity.Name),
                    new SqlParameter("@cost", entity.Cost));

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
