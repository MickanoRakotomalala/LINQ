internal class Program
{
    private static void Main(string[] args)
    {
        //SYNTAXE DE REQUETE

        //Console.WriteLine("Application Console pour voir le fonctionnement du LINQ");
        //Console.WriteLine("");
        //Console.WriteLine("Afficher les nombres pairs :");
        //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        //var nbpairs = from nb in list.OrderByDescending(n => n)
        //              where nb % 2 == 0
        //              select nb;
        //foreach(var nbpair in nbpairs)
        //{
        //    Console.WriteLine(nbpair);
        //}

        //Console.WriteLine("");
        //Console.WriteLine("Affiher liste  des gens par ordre alphabétique :");
        //List<string> Names = new List<string> {"Myriam","Henri","Maven","Alphonse","Sylvie"};
        //var noms = from n in Names.OrderBy(n => n)
        //         select n;
        //foreach(var name in noms)
        //{
        //    Console.WriteLine(name);
        //}


        //Console.WriteLine("");
        //Console.WriteLine("Travailler avec des objets en utilisant la class Person");
        //Console.WriteLine("Affiher les noms des gens plus de 25 ans :");
        //List<Person> people = new List<Person>
        //{
        //    new Person {Name = "Nathan", Age = 36},
        //    new Person {Name = "Alicia", Age = 26},
        //    new Person {Name = "Marius", Age = 16}
        //};

        //var person = from p in people.OrderBy(p => p.Name)
        //             where p.Age >= 25
        //             select p.Name;

        //foreach(var pers in person)
        //{
        //    Console.WriteLine(pers);
        //}

        //Console.WriteLine("");
        //Console.WriteLine("Grouper des nombres par parité :");
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //var groups = from n in numbers
        //             group n by n % 2 into g
        //             select new { key = g.Key, numbers = g };

        //foreach (var group in groups)
        //{
        //    Console.WriteLine(group.key == 0 ? "Even:" : "Odd");
        //    foreach (var num in group.numbers)
        //    {
        //        Console.WriteLine(num);
        //    }
        //}


        ////EXO-1 : Trouve les nombres supérieurs à 50 dans une liste d'entiers allant de 1 à 100
        //Console.WriteLine("Trouve les nombres supérieurs à 50 dans une liste d'entiers allant de 1 à 100");
        //List<int> nombres = new List<int> { 1, 5, 99, 88, 77, 25, 10, 63, 49, 51 };
        //var result = from res in nombres.OrderByDescending(x => x)
        //             where res >= 50
        //             select res;

        //foreach(var item in result)
        //{
        //    Console.WriteLine(item);
        //}


        ////EXO-2
        //Console.WriteLine("");
        //Console.WriteLine("Crée une liste de produits (nom et prix). Filtre uniquement les produits dont le prix est supérieur à 20 et affiche leurs noms :");
        //List<Produit> product = new List<Produit>
        //{
        //    new Produit{nom = "Banana",prix = 19},
        //    new Produit{nom = "Apple",prix = 25},
        //    new Produit{nom = "Yaourt",prix = 32},
        //    new Produit{nom = "Mangue",prix = 21}
        //};
        //var prodresult = from p in product.OrderBy(n => n.nom)
        //                 where p.prix >= 20
        //                 select p.nom;
        //foreach(var prod in prodresult)
        //{
        //    Console.WriteLine(prod);
        //}


        //SYNTAXE DE METHODE
        Console.WriteLine("Filtrer une liste divisible par 2 :");
        List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10 };
        var evenNumbers = numbers.Where(n => n % 2 == 0).OrderByDescending(x => x);
        foreach(var number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
        Console.WriteLine("Muliplier chaque nombre par 2 :");
        var doubledNumbers = numbers.Select(n => n * 2);
        foreach(var number in doubledNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
        Console.WriteLine("Grouper les nombres par parité (pair ou impair) :");
        var groupedNumbers = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
        foreach (var group in groupedNumbers)
        {
            Console.WriteLine(group.Key);
            foreach (var number in group)
            {
                Console.WriteLine(number);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Travailler avec les objets: ");
        Console.WriteLine("Sélectionner uniquement les noms des personnes agées de 25 ans ou plus :");
        List<Person> people = new List<Person>
        {
            new Person{Name = "Marius", Age = 24},
            new Person{Name = "Melanie", Age = 32},
            new Person{Name = "Simon", Age = 55},
            new Person{Name = "Amir", Age = 26}
        };
        var nameList = people.Where(n => n.Age >= 25).OrderBy(n => n.Name).Select(n => n.Name);
        foreach(var person in nameList)
        {
            Console.WriteLine(person);
        }

        Console.WriteLine();
        Console.WriteLine("Combiner plusieurs opérations :");
        Console.WriteLine("Filtrer, Trier et transformer une liste");
        var resultOperation = numbers.Where(n => n > 3).OrderBy(n => n).Select(n => n * 10);
        foreach(var result in resultOperation)
        {
            Console.WriteLine(result);
        }
       
    }

    //OBJET

    //class Produit
    //{
    //    public string nom { get; set; }
    //    public int prix { get; set; }
    //}

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}