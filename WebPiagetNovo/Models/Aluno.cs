namespace WebPiagetNovo.Models
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public String? Nome { get; set; }
        public String? Escola { get; set; }
        public String? Pai { get; set; }
        public String? Mae{ get; set; }
        public String? RGM { get; set; }
        public DateTime Idade { get; set; }
        public decimal Notas { get; set; }
        public String? Professor { get; set; }
    }
}
