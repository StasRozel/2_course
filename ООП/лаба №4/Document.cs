using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__4
{
    abstract class Document : IOrganization, IDate
    {
        public int DocumentId { get; set; }
        public string? Name { get; set; }

        public string? OrganizationName { get; set; }
        public string? Description { get; set; }
        public int? OrganizationId { get; set; }

        public short day { get; set; }
        public short month { get; set; }
        public short year { get; set; }

        protected string DatePrint()
        {
            if (day < 10 && month < 10)
            {
                return $"0{day}.0{month}.{year}";
            }
            else if (day > 10 && month < 10)
            {
                return $"{day}.0{month}.{year}";
            }
            else if (day < 10 && month > 10)
            {
                return $"0{day}.{month}.{year}";
            }
            else
            {
                return $"{day}.{month}.{year}";
            }
        }

        public virtual void Print()
        {
            Console.WriteLine($"Номер документа: {DocumentId}");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Индификационный номер: {OrganizationId}");
            Console.WriteLine($"Организация: {OrganizationName}");
            Console.WriteLine($"Название товара: {Name}");
            Console.WriteLine("-------------------------");
            Console.WriteLine(DatePrint());

        }

        public override string ToString()
        {

            return $"DocumentId: {DocumentId}, OrganizationId: {OrganizationId}, " +
                $"OrganizationName: {OrganizationName}, Name: {Name}, Date: {DatePrint()}";

        }


    }
}
