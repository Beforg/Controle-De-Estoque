namespace BibliotecaEstoque.Model
{
    public class Produto
    {
        public string Codigo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }

        public Produto(string codigo, string marca, string modelo, string descricao, int quantidade)
        {
            Codigo = codigo;
            Marca = marca;
            Modelo = modelo;
            Descricao = descricao;
            Quantidade = quantidade;
        }
        public Produto()
        {
        }
    }
}
