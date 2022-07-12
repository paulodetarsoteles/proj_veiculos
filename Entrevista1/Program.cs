using Entrevista1;

Carro veiculo1 = new Carro("Fiat", "Uno");
Carro veiculo2 = new Carro("Chevrolet", "Corsa");
Carro veiculo3 = new Carro("VW", "Gol");
Carro veiculo4 = new Carro("Bugatti", "Veyron");
Moto veiculo5 = new Moto("Honda");
Moto veiculo6 = new Moto("Yamaha");
Moto veiculo7 = new Moto("Shineray");
Bicicleta veiculo8 = new Bicicleta("Monark");
Bicicleta veiculo9 = new Bicicleta("Caloi");
Bicicleta veiculo10 = new Bicicleta("Houston");

List<Object> Veiculos = new() { };

Veiculos.Add(veiculo1);
Veiculos.Add(veiculo2);
Veiculos.Add(veiculo3);
Veiculos.Add(veiculo4);
Veiculos.Add(veiculo5);
Veiculos.Add(veiculo6);
Veiculos.Add(veiculo7);
Veiculos.Add(veiculo8);
Veiculos.Add(veiculo9);
Veiculos.Add(veiculo10);

veiculo1.Emplacar("XXX0000");
veiculo1.Ligar();
veiculo1.Acelerar(60);
veiculo1.Frear();
veiculo1.Desligar();
veiculo2.Emplacar("YYX2111");
veiculo2.Ligar();
veiculo2.Acelerar(40);
veiculo2.Frear();
veiculo3.Emplacar("ZZK2002");
veiculo3.Ligar();
veiculo3.Acelerar(80);
veiculo4.Ligar();
veiculo5.Emplacar("XYZ0001");
veiculo5.Ligar();
veiculo6.Emplacar("XZV1050");
veiculo7.Emplacar("XSZ1594");
veiculo8.Acelerar(20);
veiculo8.Frear();
veiculo9.Acelerar(25);

string opcao = Menu.Opcoes();
while (opcao == "1" || opcao == "2")
{
    switch (opcao)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("LISTA DE VEICULOS");
            Console.WriteLine();

            foreach (Object x in Veiculos) Console.WriteLine(x);

            Console.WriteLine();
            Console.Write("Tecle algo para voltar: ");

            string v = Console.ReadLine();
            Console.Clear();
            break;

        default:
            break;
    }
    opcao = Menu.Opcoes();
}