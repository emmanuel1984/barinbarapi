namespace Barinbar.API.Domain.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Posicao { get; set; }
        public string Linkedin { get; set; }
        public string Whatsapp { get; set; }
        public string Experiencia { get; set; }
        public string Formacao  { get; set; }
        public string Habilidades { get; set; }
        public Profissao Profissao { get; set; }
    }
}