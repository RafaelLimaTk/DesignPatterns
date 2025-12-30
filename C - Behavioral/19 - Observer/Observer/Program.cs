using Observer;

Console.Title = "Observer pattern";

TicketStockService ticketStockService = new();
TicketResellerService ticketResellerService = new();
OrderService orderService = new();

// add two observers
orderService.AddObserver(ticketStockService);
orderService.AddObserver(ticketResellerService);

// notify
orderService.ChangeTicketAmount(5, 1);

Console.WriteLine();

// remove one observer
orderService.RemoveObserver(ticketResellerService);

// notify
orderService.ChangeTicketAmount(-3, 1);

Console.ReadKey();