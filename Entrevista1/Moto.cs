using Entrevista1.Interfaces;

namespace Entrevista1
{
    internal class Moto : IVeiculoMotor
    {
        public string Marca { get; set; }
        public string Placa { get; set; }
        public int Velocidade { get; set; } = 0;
        public bool Ligado { get; set; } = false;
        public bool Parado { get; set; } = true;

        public Moto(string marca)
        {
            Marca = marca;
        }

        public override string ToString()
        {
            return "Marca: " + Marca + " \r\n" +
                    "Placa: " + Placa + " \r\n" +
                    "Parado: " + Parado + "\r\n" +
                    "Valocidade: " + Velocidade + "\r\n";
        }

        public void Emplacar(string placa)
        {
            Placa = placa;
        }

        public void Ligar()
        {
            Ligado = true;
        }

        public void Desligar()
        {
            Ligado = false;
        }

        public void Acelerar(int novaVelocidade)
        {
            if (novaVelocidade > 0)
            {
                Parado = false;
                Velocidade = novaVelocidade;
            }
            else
            {
                Parado = true;
                Velocidade = novaVelocidade;
            }

        }

        public void Frear()
        {
            Velocidade = 0;
            Parado = true;
        }
    }
}