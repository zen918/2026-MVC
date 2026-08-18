using Microsoft.AspNetCore.Mvc;

namespace MVC2026;

public class ProdutosController : Controller
{
    private List<Produto> _listaProdutos = new List<Produto>();

    public ProdutosController()
    {
        _listaProdutos.Add(new Produto{Id= Guid.NewGuid(), Nome="Chave de Fenda" , Quantidade = 65 });
        _listaProdutos.Add(new Produto{Id= Guid.NewGuid(), Nome="Alicate" , Quantidade = 99 });
        _listaProdutos.Add(new Produto{Id= Guid.NewGuid(), Nome="Martelo" , Quantidade = 37 });
        _listaProdutos.Add(new Produto{Id= Guid.NewGuid(), Nome="Parafuso" , Quantidade = 56 });
        _listaProdutos.Add(new Produto{Id= Guid.NewGuid(), Nome="Fita Isolante" , Quantidade = 82 });
    }

    public IActionResult Index()
    {
        var produtos = _listaProdutos;
        return View(produtos);
    }
    
    

}
