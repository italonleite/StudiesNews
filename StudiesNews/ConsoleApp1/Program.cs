using ConsoleApp1.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {       
        
        static void Main(string[] args)
        {
            using (var db = new MyContext())
            {
                var cliente = new Cliente()
                {
                   Id = Guid.NewGuid(),
                   Nome = "Italo"
                };

                var filipe = new Cliente()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Filipe"
                };



                db.Clientes.Add(filipe);


                //ler o blog, saber se é um blog ou rssblog

                 db.SaveChanges();

               var x = from c in db.Clientes where c.Nome == "Italo" select c.Id;


                Console.WriteLine(x.FirstOrDefault());




            }
           
        }
    }
}
