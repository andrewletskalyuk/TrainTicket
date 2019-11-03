using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Ticket_Ukr_Train
{
    [Serializable]
    public class Ticket
    {
        public string Name { get; set; }
        public string Surname  { get; set; }
        public string NumberTrain { get; set; }
        public string From { get; set; }
        public string Where { get; set; }
        public DateTime _DateTime { get; set; }
        public string TypeVagon { get; set; }
        public string Numbervagon { get; set; }
        public List<string> Servises { get; set; }
        public int fullprice { get; set; }
        public Ticket()
        {
        }
        public Ticket(string n, string sn, string nt, string from,
            string whe, DateTime dateTime, string tv, string nv,
            List<string> vs, int fullprice)
        {
            Name = n;
            Surname = sn;
            NumberTrain = nt;
            From = from;
            Where = whe;
            _DateTime = dateTime;
            TypeVagon = tv;
            Numbervagon = nv;
            Servises = vs;
            this.fullprice = fullprice; //=)
        }
        public override string ToString()
        {
            string a = "";
            Servises.ForEach(x => a += x.ToString());
            return $"{Name} name, {Surname} surname, №{NumberTrain} train number, \n" +
                $"from: {From} to: {Where} date: {_DateTime} Type vagon: {TypeVagon}\n" +
                $"number vagon: {Numbervagon}  Services:  {a} " +
                $"price:  {fullprice} ";
        }
    }
}
