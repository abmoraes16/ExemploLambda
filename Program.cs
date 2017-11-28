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

/*     var al = aluno.Where(z => z.Idade>20 && z.Idade<50);


    foreach(Alunos w in al){
        Console.WriteLine(w.Nome+" "+w.Email+" "+w.Idade+" "+w.ID);
    } */

    var al = from a in aluno where a.Email.Contains("terra") orderby a.ID descending select a.Nome;

    foreach(string w in al){
        Console.WriteLine(w);
    }

        }
    }
}
