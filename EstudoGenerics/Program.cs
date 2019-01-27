using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa
            {
                Id = 1,
                Nome = "TreinaWeb"
            };

            Animal animal = new Animal
            {
                id = 1,
                Especie = "Cachorro"
            };

            RepositorioGenerico<Pessoa> repositorioPessoa = new RepositorioGenerico<Pessoa>();
            RepositorioGenerico<Animal> repositorioAnimal = new RepositorioGenerico<Animal>();

            repositorioPessoa.Insert(pessoa);
            repositorioAnimal.Insert(animal);

            foreach (Pessoa p in repositorioPessoa.Get())
            {
                Console.WriteLine("Nome da pessoa: {0}", p.Nome);
            }

            foreach (Animal a in repositorioAnimal.Get())
            {
                Console.WriteLine("Espécie do aniamal: {0}", a.Especie);
            }

            Console.ReadKey();

        }
    }
}
