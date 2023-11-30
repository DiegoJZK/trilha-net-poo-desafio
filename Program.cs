using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone nokia: ");
Smartphone nokia = new Nokia(numero: "49999459945", modelo: "pro", imei: "1000100001", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Banco do Brasil");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "49999454545", modelo: "pro", imei: "10001011111", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Banco do Brasil");

Console.ReadLine();