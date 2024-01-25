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

        public void AddInfo(string fullname, string address, int sumcheck)
        {
            FullName = fullname;
            Address = address;
            SumCheck = sumcheck;
        }

        public override void Print()
        {
            Console.WriteLine($"Номер документа: {DocumentId}");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Индификационный номер: {OrganizationId}");
            Console.WriteLine($"Организация: {OrganizationName}");
            Console.WriteLine($"Название товара: {Name}");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Договор заключен с {FullName}");
            Console.WriteLine($"Проживающий по адресу: {Address}");
            Console.WriteLine($"На сумму: {SumCheck}руб");
        }

        public override string ToString()
        {
            return $"DocumentId: {DocumentId}, OrganizationId: {OrganizationId}, " +
                $"OrganizationName: {OrganizationName}, Name: {Name}," +
                $"FullName: {FullName}, Address: {Address}, SumCheck: {SumCheck}, Date: {DatePrint()}";
        }
    }
}
