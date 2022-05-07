namespace RealEstateLease.Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public string Proprietario { get; set; }
        public string Cep { get; set; }
        public string Endereço { get; set; }
        public string Telefone { get; set; }
        public double ValorDoAluguel { get; set; }

    }
}
