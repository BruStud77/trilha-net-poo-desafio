using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("1234567890", "Nokia 3310 2017", "1234567890", 128, 8);
Smartphone iPhone = new Iphone("0987654321", "iPhone 12 Pro Max", "0987654321", 512, 12);

// Console.WriteLine($"Especificação:{nokia.Numero}, {nokia.Modelo}, {nokia.IMEI} ");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");


// Console.WriteLine($"Especificação:{nokia.Numero}, {nokia.Modelo}, {nokia.IMEI} ");
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("WhatsApp");

