using System;
using System.Collections.Generic;
using Task1;
using Task3;

namespace Task1
{
    class Country
    {
        protected string name;
        protected string ruller;
        protected string description;
        public Country(string name, string ruller, string description)
        {
            this.name = name;
            this.ruller = ruller;
            this.description = description;
        }
        public virtual void Show()
        {
            Console.WriteLine("Name = " + name + "\nRuller = " + ruller + "\nDescription = " + description);
        }
    }
    class Republic : Country
    {
        private bool democratic_core = true;
        private bool power_inheritance = false;
        public Republic(string name, string ruller, string description, bool power_inheritance) : base(name, ruller, description)
        {
            this.power_inheritance = power_inheritance;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("This country is a Republic!");
            if (democratic_core == true && power_inheritance == false)
            {
                Console.Write(" Because it is based on democratic core and has no power inheritance");
            }
            else
            {
                Console.Write(" The Republic with inheritance of Power? Nice try! :^)");
            }
        }
    }
    class Kingdom : Country
    {
        private bool power_inheritance = true;
        public Kingdom(string name, string ruller, string description, bool power_inheritance) : base(name, ruller, description)
        {
            this.power_inheritance = power_inheritance;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("This country is a Kingdom!");
            if (power_inheritance != true)
            {
                Console.Write("...Without a King or a Queen? Strange indeed!");
            }
        }
    }
    class Monarchy : Kingdom
    {
        private int type;
        public Monarchy(string name, string ruller, string description, int type) : base(name, ruller, description, true)
        {
            this.type = type;
        }

        public override void Show()
        {
            Console.WriteLine("Name = " + name + "\nRuller = " + ruller + "\nDescription = " + description);
            Console.WriteLine("Your country automatically become a Kingdom, because You are a Monarch!");
            if (type == 1)
            {
                Console.WriteLine("And Monarchy is constitutional :^c");
            }
            else
            {
                Console.WriteLine("And Monarchy is absolute! >:^)");
            }
        }
    }
}

namespace Task2
{
    class Country
    {
        protected string name;
        protected string ruller;
        protected string description;
        ~Country() { Console.WriteLine("Destructor of the class Country"); }
        public Country()
        {
            Console.WriteLine("Constructor of the class Country");
            name = "Unnamed";
            ruller = "Undefined";
            description = "none";
        }
        public Country(string name, string ruller, string description)
        {
            Console.WriteLine("Constructor of class Country");
            this.name = name;
            this.ruller = ruller;
            this.description = description;
        }
        public virtual void Show()
        {
            Console.WriteLine("Name = " + name + "\nRuller = " + ruller + "\nDescription = " + description);
        }
    }
    class Republic : Country
    {
        private bool democratic_core = true;
        private bool power_inheritance = false;
        ~Republic() { Console.WriteLine("Destructor of the class Republic"); }
        public Republic() : base("Unnamed", "Undefined", "none")
        {
            Console.WriteLine("Constructor of the class Republic");
        }
        public Republic(string name, string ruller, string description, bool power_inheritance) : base(name, ruller, description)
        {
            this.power_inheritance = power_inheritance;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("This country is a Republic!");
            if (democratic_core == true && power_inheritance == false)
            {
                Console.Write(" Because it is based on democratic core and has no power inheritance");
            }
            else
            {
                Console.Write(" The Republic with inheritance of Power? Nice try! :^)");
            }
        }
    }
    class Kingdom : Country
    {
        private bool power_inheritance = true;
        ~Kingdom() { Console.WriteLine("Destructor of the class Kingdom"); }
        public Kingdom() : base("Unnamed", "Undefined", "none")
        {

            Console.WriteLine("Constructor of the class Kingdom");
        }
        public Kingdom(string name, string ruller, string description, bool power_inheritance) : base(name, ruller, description)
        {
            this.power_inheritance = power_inheritance;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("This country is a Kingdom!");
            if (power_inheritance != true)
            {
                Console.Write("...Without a King or a Queen? Strange indeed!");
            }
        }
    }
    class Monarchy : Kingdom
    {
        private int type;
        ~Monarchy() { Console.WriteLine("Destructor of the class Monarchy"); }
        public Monarchy() : base()
        {
            Console.WriteLine("Constructor of the class Monarchy");
            type = 0;
        }
        public Monarchy(string name, string ruller, string description, int type) : base(name, ruller, description, true)
        {
            this.type = type;
        }

        public override void Show()
        {
            Console.WriteLine("Name = " + name + "\nRuller = " + ruller + "\nDescription = " + description);
            Console.WriteLine("Your country automatically become a Kingdom, because You are a Monarch!");
            if (type == 1)
            {
                Console.WriteLine("And Monarchy is constitutional :^c");
            }
            else
            {
                Console.WriteLine("And Monarchy is absolute! >:^)");
            }
        }
    }
}

namespace Task3
{
    abstract class Publication
    {
        string name;
        string author_lastname;
        public Publication(string name, string author_lastname)
        {
            this.name = name;
            this.author_lastname = author_lastname;
        }
        abstract public void Show();
        public string GetName()
        {
            return name;
        }
        public string GetAuthorLastname()
        {
            return author_lastname;
        }

    }

    class Book : Publication
    {
        uint publication_year;
        string publisher;
        public Book(string name, string author_lastname, uint publish_year, string publisher) : base(name, author_lastname)
        {
            this.publication_year = publish_year;
            this.publisher = publisher;
        }
        public override void Show()
        {
            Console.WriteLine("\n\tInformation about the book:\nIts name = " + base.GetName() + "\nAuthor Lastname = " + base.GetAuthorLastname() +
               "\nYear = " + publication_year + "\nPublisher = " + publisher);
        }
    }

    class Article : Publication
    {
        string magazine_name;
        string magazine_number;
        uint publication_year;
        public Article(string name, string author_lastname, string magazine_name, string magazine_number, uint publication_year) : base(name, author_lastname)
        {
            this.publication_year = publication_year;
            this.magazine_name = magazine_name;
            this.magazine_number = magazine_number;
        }
        public override void Show()
        {
            Console.WriteLine("\n\tInformation about the Article:\nIts name = " + base.GetName() + "\nAuthor Lastname = " + base.GetAuthorLastname() + "\nMagazine name = " + magazine_name +
               "\nMagazine number = " + magazine_number + "\nYear = " + publication_year);
        }
    }

    class Blog : Publication
    {
        string link, annotation;
        public Blog(string name, string author_lastname, string link, string annotation) : base(name, author_lastname)
        {
            this.link = link;
            this.annotation = annotation;
        }
        public override void Show()
        {
            Console.WriteLine("\n\tInformation about the Blog:\nIts name = " + base.GetName() + "\nAuthor Lastname = " + base.GetAuthorLastname() +
                "\nLink = " + link + "\nAnnotation = " + annotation);
        }
    }

    class Catalogue
    {
        List<Publication> catalog = new List<Publication>();
        public void AddPublication(Publication n)
        {
            catalog.Add(n);
        }
        public void ShowAll()
        {
            foreach (var c in catalog) c.Show();
        }
        public bool FindAuthor(string lastname)
        {
            bool success = false;
            foreach (var c in catalog.FindAll(c => c.GetAuthorLastname() == lastname))
            {
                c.Show();
                success = true;
            }
            return success;
        }
    }

}

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\tLab 2\nThere are tasks with numbers 1.13, 2.13, 3.3\nChoose the one you want to start:");
                String task_number = Console.ReadLine();
                switch (task_number)
                {
                    case "1.13":
                        Console.WriteLine("Input the name of your country, its ruller and the descriprion!");
                        string name = Console.ReadLine(), ruller = Console.ReadLine(), description = Console.ReadLine();
                        Console.WriteLine("What country you want to create? a Republic = Key '1', a Kingdom = Key '2', a Monarchy = Key '3'\nKey'4' = Stop asking me! Just a country!");
                        string input = Console.ReadLine();
                        if (input == "1")
                        {
                            Console.WriteLine("A Republic cannot have an inheritance of Power, yes ._.?   (Y/N) ");
                            string choice = Console.ReadLine();
                            if (choice == "Y" || choice == "Yes" || choice == "y" || choice == "yes")
                            {
                                Republic republic = new Republic(name, ruller, description, false); republic.Show();
                            }
                            else { Republic republic = new Republic(name, ruller, description, true); republic.Show(); }
                        }
                        else if (input == "2")
                        {
                            Console.WriteLine("Your Kingdom have an inheritance of Power, yes? (Y/N) ");
                            string choice = Console.ReadLine();
                            if (choice == "Y" || choice == "Yes" || choice == "y" || choice == "yes")
                            {
                                Kingdom kingdom = new Kingdom(name, ruller, description, true); kingdom.Show();
                            }
                            else { Kingdom kingdom = new Kingdom(name, ruller, description, false); kingdom.Show(); }

                        }
                        else if (input == "3")
                        {
                            Console.WriteLine("Input the type of your monarchy. Constitutional = Key '1', for Absolute Monarchy... it's your choice, You're the ruller!");
                            string choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                Monarchy monarchy = new Monarchy(name, ruller, description, 1); monarchy.Show();
                            }
                            else { Monarchy monarchy = new Monarchy(name, ruller, description, 0); monarchy.Show(); }

                        }
                        else if (input == "4")
                        {
                            Country country = new Country(name, ruller, description); country.Show();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input");
                        }
                        break;
                    case "2.13":
                        do
                        {
                            Console.WriteLine("Choose a class that you want to create: 1 - Country, 2 - Republic, 3 - Kingdom, 4 - Monarchy");
                            task_number = Console.ReadLine();
                            if (task_number == "1")
                            {
                                Task2.Country c = new Task2.Country();
                                Console.WriteLine("Destructor of the class Country");
                            }
                            else if (task_number == "2")
                            {
                                Task2.Republic r = new Task2.Republic();
                                Console.WriteLine("Destructor of the class Republic");
                                Console.WriteLine("Destructor of the class Country");
                            }
                            else if (task_number == "3")
                            {
                                Task2.Kingdom k = new Task2.Kingdom();
                                Console.WriteLine("Destructor of the class Kingdom");
                                Console.WriteLine("Destructor of the class Country");
                            }
                            else if (task_number == "4")
                            {
                                Task2.Monarchy m = new Task2.Monarchy();
                                Console.WriteLine("Destructor of the class Monarchy");
                                Console.WriteLine("Destructor of the class Kingdom");
                                Console.WriteLine("Destructor of the class Country");
                            }
                            else Console.WriteLine("You've chosen a wrong number");
                            Console.WriteLine("Do you wanna try again? (Y/N)");
                            input = Console.ReadLine();
                        } while (input == "Y" || input == "Yes" || input == "y" || input == "yes");
                        break;
                    case "3.3":
                        Catalogue catalog = new Catalogue();
                        do
                        {
                            Console.WriteLine("What item do you wanna add into the catalogue? 1 - Book, 2 - Article, 3 - Blog\n4 - To show all items, 5 - to find a publication by author lastname ");
                            input = Console.ReadLine();
                            if (input == "1")
                            {
                                catalog.AddPublication(new Book("BookName", "Author", 2000, "Publisher"));
                            }
                            else if (input == "2")
                            {
                                catalog.AddPublication(new Article("ArticleName", "Author", "Mag_name", "1223", 2000));
                            }
                            else if (input == "3")
                            {
                                catalog.AddPublication(new Blog("BlogName", "Aur", "link", "Publisher"));
                            }
                            else if (input == "4") catalog.ShowAll();
                            else if (input == "5")
                            {
                                Console.WriteLine("Publications with the author lastname 'Author': ");
                                if (catalog.FindAuthor("Author") == false) Console.WriteLine("Sorry, can't find it ;c");
                            }
                            else Console.WriteLine("You've chosen a wrong number");
                            Console.WriteLine("\nDo you want to continue? (Y/N)");
                            input = Console.ReadLine();
                        } while (input == "Y" || input == "Yes" || input == "y" || input == "yes");
                        break;
                    default: Console.WriteLine("You've chosen a wrong number. There is no such a task"); Console.ReadLine(); break;

                }
                Console.ReadLine();
            }
        }
    }
}