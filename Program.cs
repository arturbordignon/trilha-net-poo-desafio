using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Nokia 3310", imei: "12345678", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "Iphone 14", imei: "87654321", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
