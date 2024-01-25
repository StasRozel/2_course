using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace лаба__4
{
    class AccountingContainer
    {
        private List<Document> documents = new List<Document>();


        public Document GetBeginDocument
        {
            get
            {
                return documents.First();
            }
        }

        public Document GetEndDocument
        {
            get
            {
                return documents.Last();
            }
        }

        public List<Document> GetAllDocuments
        {
            get
            {
                return documents;
            }
        }

        public void AddDocument(Document doc)
        {
            documents.Add(doc);
        }

        public void RemoveDocument(Document doc)
        {
            documents.Remove(doc);
        }

        public void PrintAllDocuments()
        {
            foreach (Document doc in documents)
            {
                Console.WriteLine(doc.ToString());
            }
        }

    }
}
