using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Categoria
{
    public int id { get; set; }
    public String descricao { get; set; }
    public String picture { get; set; }
    public IList<SubCategoria> SubcategoriasList { get; set; }

	public Categoria()
	{
		 
	}
}
