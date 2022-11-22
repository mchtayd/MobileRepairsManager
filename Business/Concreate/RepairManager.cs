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
    public class RepairManager //: IRepository<Repair>
    {
        static RepairManager repairManager;
        RepairDal repairDal;
        string controlText;

        private RepairManager()
        {
            repairDal = RepairDal.GetInstance();
        }
        public static RepairManager GetInstance()
        {
            if (repairManager == null)
            {
                repairManager = new RepairManager();
            }
            return repairManager;
        }

        public string Add(Repair entity)
        {
            try
            {
                controlText = Complete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return repairDal.Add(entity);
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
                return repairDal.Delete(id);
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
                return repairDal.Get(id);
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
                return repairDal.GetList();
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
        string Complete(Repair repair)
        {
            if (string.IsNullOrEmpty(repair.Costomer))
            {
                return "Lütfen COSTOMER Bilgisini doldurunuz.";
            }
            if (string.IsNullOrEmpty(repair.PhoneNumber))
            {
                return "Lütfen PHONE NUMBER Bilgisini doldurunuz.";
            }
            if (string.IsNullOrEmpty(repair.DeviceName))
            {
                return "Lütfen DEVİCE NAME Bilgisini doldurunuz.";
            }
            if (string.IsNullOrEmpty(repair.DeviceModel))
            {
                return "Lütfen DEVİCE MODEL Bilgisini doldurunuz.";
            }
            if (string.IsNullOrEmpty(repair.Problem))
            {
                return "Lütfen PROBLEM Bilgisini doldurunuz.";
            }
            if (string.IsNullOrEmpty(repair.Spare))
            {
                return "Lütfen SPARE Bilgisini doldurunuz.";
            }

            return "";
        }
    }
}
