namespace Entrevista1
{
    internal class Bicicleta
    {
        public string Marca { get; set; }
        public int Velocidade { get; set; } = 0;
        public bool Parado { get; set; } = true;

        public Bicicleta(string marca)
        {
            Marca = marca;
        }

        public override string ToString()
        {
            return "Marca: " + Marca + " \r\n" +
                    "Parado: " + Parado + "\r\n" +
                    "Valocidade: " + Velocidade + "\r\n";
        }

        public void Acelerar(int novaVelocidade)
        {
            if (novaVelocidade > 0) Parado = false;
            Velocidade = novaVelocidade;
        }

        public void Frear()
        {
            Velocidade = 0;
            Parado = true;
        }
    }
}