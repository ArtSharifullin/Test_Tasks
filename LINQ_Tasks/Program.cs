using LINQ_Tasks;

Console.WriteLine("\n--------------------Task 2----------------------\n");
var info = new List<Client>();
info.Add(new Client(10, 2024, 1, 324));
info.Add(new Client(1, 2022, 2, 34));
info.Add(new Client(5, 224, 3, 666));
info.Add(new Client(7, 2018, 4, 3204));
info.Add(new Client(12, 2824, 5, 3204));
info.Add(new Client(12, 2824, 5, 3204));



var clients = new Clients(info);
clients.GetMaxClients();

Console.WriteLine("\n--------------------Task 10----------------------\n");
var clients2 = new Clients_Counter(info);
clients2.GetClientsCount();