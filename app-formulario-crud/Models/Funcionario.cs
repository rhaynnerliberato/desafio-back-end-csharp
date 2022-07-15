namespace app_formulario_crud.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool Habilitacao { get; set; }
        public string Categoria { get; set; }
        public string LinguaEstrangeira { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cargo { get; set; }
        public float SalarioProposto { get; set; }
    }
}
