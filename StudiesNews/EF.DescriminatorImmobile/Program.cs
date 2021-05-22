using EF.DescriminatorImmobile.Context;
using EF.DescriminatorImmobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF.DescriminatorImmobile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ImovelContext())
            {
                var casa = new Comercial()
                {
                    Id = Guid.NewGuid(),
                    TipoImovel = "Casa"
                };

                var consultorio = new Comercial()
                {
                    Id = Guid.NewGuid(),
                    TipoImovel = "Consultório"
                };
                var galpao = new Comercial()
                {
                    Id = Guid.NewGuid(),
                    TipoImovel = "Galpão/Depósito/Garagem"
                };
                var sala = new Comercial()
                {
                    Id = Guid.NewGuid(),
                    TipoImovel = "Sala/Conjunto"
                };

                
                db.Comerciais.Add(casa);
                db.Comerciais.Add(consultorio);
                db.Comerciais.Add(galpao);
                db.Comerciais.Add(sala);

                Console.WriteLine("Digite o Id");
                var id = Guid.Parse(Console.ReadLine());

                var tipo = from t in db.Tipos where t.Id == id select t.GetType().Name;

                Console.WriteLine("Resultado: {0}", tipo.FirstOrDefault());


                //    db.SaveChanges();

            }
        }
    }
}
