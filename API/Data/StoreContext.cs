using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; } // Representa a tabela do banco.
    }
}

/*
Esse arquivo se trata do modelo que mapeia as entidades
e relações definidas no nosso modelo de tabelas em um banco de dados.

A classe primária do aplicativo interage é o System.Data.Entity.DbContext.

A partir do momento em que é criado, usamos com esses métodos:

Add/Attach (Adiciona)
Remove     (Remove)

Acessamos a propriedade DbSet em um objeto de contexto, representa
uma consulta inicial que retorna todas as entidades do tipo especificado.

A consulta é executada quando:
É enumerada por um foreach (c#) ou For Each (Visual Basic).
Operação de coleção ToArray, ToDictionary ou ToList.
Operações LINQ: First ou Any.
*/