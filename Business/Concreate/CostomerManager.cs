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
    public class CostomerManager //: IRepository<Costomer>
    {
        static CostomerManager costomerManager;
        CostomerDal costomerDal;
        string controlText;

        private CostomerManager()
        {
            costomerDal = CostomerDal.GetInstance();
        }
        public static CostomerManager GetInstance()
        {
            if (costomerManager == null)
            {
                costomerManager = new CostomerManager();
            }
            return costomerManager;
        }

        public string Add(Costomer entity)
        {
            try
            {
                controlText = Complete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return costomerDal.Add(entity);
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
                return costomerDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Costomer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Costomer> GetList()
        {
            try
            {
                return costomerDal.GetList();
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
                controlText = Complete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return costomerDal.Update(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        string Complete(Costomer costomer)
        {
            if (string.IsNullOrEmpty(costomer.Name))
            {
                return "Lütfen NAME Bilgisini doldurunuz.";
            }
            if (string.IsNullOrEmpty(costomer.Phone))
            {
                return "Lütfen PHONE Bilgisini doldurunuz.";
            }
            if (string.IsNullOrEmpty(costomer.Adress))
            {
                return "Lütfen ADRESS Bilgisini doldurunuz.";
            }
            
            return "";
        }
    }
}
