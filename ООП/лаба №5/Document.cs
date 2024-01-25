using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace лаба__4
{
    partial class Document
    {
        public struct Struct
        {

        }

        protected enum Sings
        {
            Signature,
            Seal,
            Watermark
        }
    }

    partial class Document : IOrganization, IDate
    {
        public int DocumentId { get; set; }
        public string? DocumentName { get; set; }

        public string? OrganizationName { get; set; }
        public string? Description { get; set; }
        public int? OrganizationId { get; set; }

        

        protected DateTime date;

        public DateTime GetDate(int day, int month, int year)
        {
            date = new DateTime(year, month, day);

            return date;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Номер документа: {DocumentId}");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Индификационный номер: {OrganizationId}");
            Console.WriteLine($"Организация: {OrganizationName}");
            Console.WriteLine($"Название товара: {DocumentName}");
            Console.WriteLine("-------------------------");
            Console.WriteLine(date);
        }

        public override string ToString()
        {
            return $"DocumentId: {DocumentId}, OrganizationId: {OrganizationId}, " +
                $"OrganizationName: {OrganizationName}, Name: {DocumentName}, Date: {date}";
        }


    }
}
