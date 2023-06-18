// See https://aka.ms/new-console-template for more information

using ConsoleApp6;

var builder = new BurgerBuilder();

var bigTastyMaker = new BigTastyMaker(builder);

bigTastyMaker.Build();

var bigTastyBurger = builder.GetBurger();

var bigMagMaker = new BigMagMaker(builder);
bigMagMaker.Build();
var bigMagBurger = builder.GetBurger();


var bigMagMakerNoOninon = new BigMagMakerWithoutOnin(builder);
bigMagMakerNoOninon.Build();
var bigMagWithoutOninBurger = builder.GetBurger();
Console.WriteLine("Hello, World!");
