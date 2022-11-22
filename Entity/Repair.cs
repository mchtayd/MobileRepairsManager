using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Repair
    {
        int id; DateTime date; string costomer, phoneNumber, deviceName, deviceModel, problem, spare; int totalCost;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Costomer { get => costomer; set => costomer = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string DeviceName { get => deviceName; set => deviceName = value; }
        public string DeviceModel { get => deviceModel; set => deviceModel = value; }
        public string Problem { get => problem; set => problem = value; }
        public string Spare { get => spare; set => spare = value; }
        public int TotalCost { get => totalCost; set => totalCost = value; }

        public Repair(int id, DateTime date, string costomer, string phoneNumber, string deviceName, string deviceModel, string problem, string spare, int totalCost)
        {
            this.id = id;
            this.date = date;
            this.costomer = costomer;
            this.phoneNumber = phoneNumber;
            this.deviceName = deviceName;
            this.deviceModel = deviceModel;
            this.problem = problem;
            this.spare = spare;
            this.totalCost = totalCost;
        }

        public Repair(DateTime date, string costomer, string phoneNumber, string deviceName, string deviceModel, string problem, string spare, int totalCost)
        {
            this.date = date;
            this.costomer = costomer;
            this.phoneNumber = phoneNumber;
            this.deviceName = deviceName;
            this.deviceModel = deviceModel;
            this.problem = problem;
            this.spare = spare;
            this.totalCost = totalCost;
        }
    }
}
