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
    public class PartManager // : IRepository<Part>
    {
        static PartManager partManager;
        PartDal partDal;
        string controlText;

        private PartManager()
        {
            partDal = PartDal.GetInstance();
        }

        public static PartManager GetInstance()
        {
            if (partManager == null)
            {
                partManager = new PartManager();
            }
            return partManager;
        }

        public string Add(Part entity)
        {
            try
            {
                controlText = Complete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return partDal.Add(entity);
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
                return partDal.Delete(id);
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
                return partDal.Get(id);
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
                return partDal.GetList();
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
                controlText = Complete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return partDal.Update(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        string Complete(Part part)
        {
            if (string.IsNullOrEmpty(part.Name))
            {
                return "Lütfen NAME Bilgisini doldurunuz.";
            }
            if (string.IsNullOrEmpty(part.Cost.ToString()))
            {
                return "Lütfen PART COST Bilgisini doldurunuz.";
            }
            return "";
        }
    }
}
