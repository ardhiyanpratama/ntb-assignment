// See https://aka.ms/new-console-template for more information
using FizzApps.Core.IRepository;
using FizzApps.Core.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var provider = new ServiceCollection()
    .AddSingleton<IFizzRepository, FizzRepository>()
    .BuildServiceProvider();

var FizzService = provider.GetRequiredService<IFizzRepository>();

int a;

Console.WriteLine("Please enter a sequence number : ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Result : " + await FizzService.Fizz(a));
Console.ReadLine();

