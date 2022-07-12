namespace Entrevista1.Interfaces
{
    public interface IVeiculoMotor
    {
        public string Marca { get; set; }
        public string Placa { get; set; }
        public int Velocidade { get; set; }
        public bool Ligado { get; set; }
        public bool Parado { get; set; } 
    }
}