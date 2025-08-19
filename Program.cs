using DesafioPOO.Models;

Nokia n = new Nokia(numero: "123456", modelo: "D620", imei: "123456789", memoria: 120);
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("AppNokia");

Iphone i = new Iphone(numero: "123456", modelo: "Iphone14", imei: "123456789", memoria: 120);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("AppIphone");