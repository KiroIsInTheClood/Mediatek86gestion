namespace Mediatek86.metier
{
    public class Service
    {
        private readonly int service;

        public Service(int service)
        {
            this.service = service;
        }

        public int ServiceInt { get => service; }
    }
}
