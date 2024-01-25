using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__4
{
    sealed class Invoice : Document
    {
        private string? FullName;
        private string? Address;
        private int SumCheck;

        private Sings signature = Sings.Signature;
        private Sings watermark = Sings.Watermark;
        private Sings seal = Sings.Seal;

        public Invoice(int DocId, string OrgName, int OrgId, string Name)
        {
            DocumentId = DocId;
            OrganizationName = OrgName;
            OrganizationId = OrgId;
            DocumentName = Name;
        }

        public void AddInfo(string fullname, string address, int sumcheck)
        {
            FullName = fullname;
            Address = address;
            SumCheck = sumcheck;
        }

        public DateTime GetDateTime()
        {
            return date;
        }

        public override void Print()
        {
            Console.WriteLine($"Номер документа: {DocumentId}");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Индификационный номер: {OrganizationId}");
            Console.WriteLine($"Организация: {OrganizationName}");
            Console.WriteLine($"Название товара: {DocumentName}");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Договор заключен с {FullName}");
            Console.WriteLine($"Проживающий по адресу: {Address}");
            Console.WriteLine($"На сумму: {SumCheck}руб");
            Console.WriteLine("-------------------------");
            Console.WriteLine(date.ToShortDateString());
        }

        public override string ToString()
        {
            return $"DocumentId: {DocumentId}, OrganizationId: {OrganizationId}, " +
                $"OrganizationName: {OrganizationName}, Name: {DocumentName}," +
                $"FullName: {FullName}, Address: {Address}, SumCheck: {SumCheck}, Date: {date.ToShortDateString()}";
        }
    }
}
