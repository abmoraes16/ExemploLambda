using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemploLambda
{
    class Program
    {
        static void Main(string[] args)
        {
/// <summary>
/// Exemplo Cidades
/// </summary>
/// <returns></returns>

            List<string> cidades = new List<string>();
            
            cidades.Add("Campinas");
            cidades.Add("Guarulhos");
            cidades.Add("Salvador");
            cidades.Add("Belo Horizonte");

            var cid = cidades.Where(x => x.Length <10);

            foreach(string cidade in cid){
                Console.WriteLine(cidade.ToUpper());
            }

/// <summary>
/// Exemplo Alunos
/// </summary>
/// <returns></returns>

     List<Alunos> aluno = new List<Alunos>(){
         new Alunos{ID=12,Nome="Fabiana",Email="fabi@mail.com",Idade=21},
         new Alunos{ID=13,Nome="Marcos",Email="marcos@terra.com",Idade=18},
         new Alunos{ID=14,Nome="Pablo",Email="pablo@mail.com",Idade=19},
         new Alunos{ID=15,Nome="Pedro",Email="pedro@terra.com",Idade=17}
     };

    //LINQ

    /*     var al = from a in aluno where a.Idade > 20 && a.Idade <50 select a;

        foreach(Alunos w in al){
            Console.WriteLine(w.Nome+" "+w.Email+" "+w.Idade+" "+w.ID);
        } */

    //LAMBDA

    //EXEMPLO1
    /*     var al = aluno.Where(z => z.Idade>20 && z.Idade<50);


        foreach(Alunos w in al){
            Console.WriteLine(w.Nome+" "+w.Email+" "+w.Idade+" "+w.ID);
        } */

    //EXEMPLO2

    /*     var al = from a in aluno where a.Email.Contains("terra") orderby a.ID descending select a.Nome;

        foreach(string w in al){
            Console.WriteLine(w);
        } */

    //EXEMPLO3

        /* var al = aluno.Count(a => a.Email.Contains("terra"));
        Console.WriteLine(al); */


        List<Produto> prod = new List<Produto>(){
            new Produto{IdProduto=1,NomeProduto="Lapis",Preco=2,IdFornecedor=30},
            new Produto{IdProduto=2,NomeProduto="Borracha",Preco=5,IdFornecedor=41},
            new Produto{IdProduto=3,NomeProduto="Caneta",Preco=10,IdFornecedor=30},
            new Produto{IdProduto=4,NomeProduto="Caderno",Preco=20,IdFornecedor=41}
        };

        List<Fornecedor> forn = new List<Fornecedor>(){
            new Fornecedor{IdFornecedor=30, RazaoSocial="Faber Castel",Telefone="11"},
            new Fornecedor{IdFornecedor=41, RazaoSocial="BIC",Telefone="56"},
            new Fornecedor{IdFornecedor=51, RazaoSocial="Chameco",Telefone="45"}
        };

            var resultado = prod.Join(
                forn, 
                p => p.IdFornecedor,
                f => f.IdFornecedor,
                (p,f) => new {
                    pNome = p.NomeProduto,
                    fRazao = f.RazaoSocial
            });

            foreach(var x in resultado){
                Console.WriteLine(x.pNome+" - "+x.fRazao);
            }

        }
    }
}
