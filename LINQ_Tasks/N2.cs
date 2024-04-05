using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tasks
{
    public class Clients
    {
        private List<Client> clients = new List<Client>();
        public Clients(List<Client> info)
        {
            clients = info;
        }

        public void GetMaxClients() 
        {
            var max_value = clients.Max(m => m.Duration);
            var selected = clients.OrderByDescending(p => p.Duration).Where(p => p.Duration == max_value);

            Console.WriteLine($"Самая больша продолжительность равна {max_value,5}"); 

            foreach (var client in selected)
            {
                Console.WriteLine(client);
            }
        }
    }

    public class Client
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int Id { get; set; }
        public int Duration { get; set; }

        public Client(int m, int y, int i, int d)
        {
            Month = m;
            Year = y;
            Id = i;
            Duration = d;
        }

        public override string ToString()
        {
            return $"{Month,2} {Year,4} {Id,3} {Duration,5}";
        }
    }
}
