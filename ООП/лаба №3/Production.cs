using System;

namespace лаба__3
{
    class Production
    {
        private readonly Guid id = new Guid();
        private string organization;

        public Production(string organization)
        {
            this.organization = organization;
        }

        public void Print()
        {
            Console.WriteLine($"ID: {id} \n Имя органицазии: {organization}");
        }
    }
}
