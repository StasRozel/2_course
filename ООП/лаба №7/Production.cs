using System;

namespace лаба__7
{
    class Production<T> where T : class
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
