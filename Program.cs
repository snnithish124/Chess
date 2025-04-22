using Chess.Models;
using Chess.Utils;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// Step 2: Register services
//services.AddSingleton<IMessageService, ConsoleMessageService>();

// Step 3: Build service provider
var serviceProvider = services.BuildServiceProvider();

// Step 4: Use service
//var messageService = serviceProvider.GetRequiredService<IMessageService>();
//messageService.Send("Hello from DI in Console App!"); Console.WriteLine("Hello, World!");
IChessBoard board = new BasicChessBoard();

board.print();
Console.ReadLine();
