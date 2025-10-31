namespace App.Core.Model
{
	public class MercadoModel
	{
		public string Nome { get; set; } = string.Empty;
		public List<ProdutoModel> ProdutoList { get; set; } = new();
	}
}