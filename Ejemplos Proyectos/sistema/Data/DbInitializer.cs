using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Models;


namespace Sistema.Data
{
    public class DBInitializer
    {
        public static void Initialize(sistemaContext context)
        {
            context.Database.EnsureCreated();

            //Buscar si existen registros en la tabla categoría
            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[] // si no existe se crean datos de pruebas
            {
                
                new Categoria{Nombre="Programación",Descripcion="Cursos de programación",Estado=true},
                new Categoria{Nombre="Diseño gráfico",Descripcion="Cursos de diseño gráfico",Estado=true}
            };

            foreach (Categoria c in categorias)// recorre todo el vector categorias
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();

        }
    }
}