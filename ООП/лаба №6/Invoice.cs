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
        private bool flagException = false;

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
            try
            {
                if (fullname != "")
                {
                    FullName = fullname;
                }
                else
                {
                    throw new AddedInfoExcepiton("Ошибка: Не введена ФИО");
                }
                if (address != "")
                {
                    Address = address;
                }
                else
                {
                    throw new AddedInfoExcepiton("Ошибка: Не введен адресс");
                }
                if (sumcheck >= 0)
                {
                    SumCheck = sumcheck;
                }
                else
                {
                    throw new AddedInfoExcepiton("Ошибка: Сумма выплаты отрицательна");
                }
            } catch (AddedInfoExcepiton ex)
            {
                flagException = true;
                Console.WriteLine(ex.Message);
            }            
        } 

        public DateTime GetDateTime()
        {
            return date;
        }

        public override void Print()
        {
            if (!flagException)
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
        }

        public override string ToString()
        {
            return $"DocumentId: {DocumentId}, OrganizationId: {OrganizationId}, " +
                $"OrganizationName: {OrganizationName}, Name: {DocumentName}," +
                $"FullName: {FullName}, Address: {Address}, SumCheck: {SumCheck}, Date: {date.ToShortDateString()}";
        }
    }
}
