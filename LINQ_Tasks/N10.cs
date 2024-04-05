using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tasks
{
    public class Clients_Counter
    {
        private List<Client> clients = new List<Client>();
        public Clients_Counter(List<Client> info)
        {
            clients = info;
        }

        /*Для каждой пары «год–месяц», присутствующей в исходных
данных, определить количество клиентов, которые посещали

центр в указанное время(вначале выводится год, затем ме-
сяц, затем количество клиентов). Сведения о каждой паре

«год–месяц» выводить на новой строке и упорядочивать по
убыванию номера года, а для одинакового номера года — по
возрастанию номера месяца.*/

        public void GetClientsCount ()
        {
            foreach (Client client in clients) 
            {
                var c = clients.Count(m => m.Year == client.Year && m.Month == client.Month);
                Console.WriteLine($"{client.Year} {client.Month} {c}");
            }
        }
    }
}
