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
    public class RepairDal // : IRepository<Repair>
    {
        static RepairDal repairDal;
        SqlServices sqlServices;
        SqlDataReader dataReader;

        private RepairDal()
        {
            sqlServices = SqlDatabase.GetInstance();
        }
        public static RepairDal GetInstance()
        {
            if (repairDal == null)
            {
                repairDal = new RepairDal();
            }
            return repairDal;
        }
        public string Add(Repair entity)
        {
            try
            {
                dataReader = sqlServices.StoreReader("RepairAdd",
                    new SqlParameter("@date", entity.Date),
                    new SqlParameter("@costomer", entity.Costomer),
                    new SqlParameter("@phoneNumber", entity.PhoneNumber),
                    new SqlParameter("@deviceName", entity.DeviceName),
                    new SqlParameter("@deviceModel", entity.DeviceModel),
                    new SqlParameter("@problem", entity.Problem),
                    new SqlParameter("@spare", entity.Spare),
                    new SqlParameter("@totalCost", entity.TotalCost));

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
                sqlServices.Stored("RepairDelete", new SqlParameter("@id", id));
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Repair Get(int id)
        {
            try
            {
                dataReader = sqlServices.StoreReader("RepairList", new SqlParameter("@id", id));
                Repair item = null;
                while (dataReader.Read())
                {
                    item = new Repair(
                        dataReader["ID"].ConInt(),
                        dataReader["DATE"].ConDate(),
                        dataReader["COSTOMER"].ToString(),
                        dataReader["PHONE_NUMBER"].ToString(),
                        dataReader["DEVICE_NAME"].ToString(),
                        dataReader["DEVICE_MODEL"].ToString(),
                        dataReader["PROBLEM"].ToString(),
                        dataReader["SPARE"].ToString(),
                        dataReader["TOTAL_COST"].ConInt());
                }
                dataReader.Close();
                return item;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Repair> GetList()
        {
            try
            {
                List<Repair> repairs = new List<Repair>();
                dataReader = sqlServices.StoreReader("RepairList");
                while (dataReader.Read())
                {
                    repairs.Add(new Repair(
                        dataReader["ID"].ConInt(),
                        dataReader["DATE"].ConDate(),
                        dataReader["COSTOMER"].ToString(),
                        dataReader["PHONE_NUMBER"].ToString(),
                        dataReader["DEVICE_NAME"].ToString(),
                        dataReader["DEVICE_MODEL"].ToString(),
                        dataReader["PROBLEM"].ToString(),
                        dataReader["SPARE"].ToString(),
                        dataReader["TOTAL_COST"].ConInt()));
                }
                dataReader.Close();
                return repairs;
            }
            catch (Exception)
            {
                return new List<Repair>();
            }
        }

        public string Update(Repair entity)
        {
            throw new NotImplementedException();
        }
    }
}
