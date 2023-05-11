using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//A comment line for the new branch
namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies= new List<Movie>()
        {
            new Movie {Id=1,Name="KGF 2",Cost=225},
            new Movie{Id= 1, Name= "KGF ", Cost= 200}
        };

        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
