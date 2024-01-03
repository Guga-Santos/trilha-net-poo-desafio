using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("99999999", "6120", "123123", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("98888888", "12", "123321", 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");