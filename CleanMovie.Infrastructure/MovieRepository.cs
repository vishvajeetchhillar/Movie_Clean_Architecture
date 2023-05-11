using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//A c
namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies= new List<Movie>()
        {
            new Movie {Id=1,Name="KGF 2",Cost=225},
            new Movie{Id= 1, Name= "KGF ", Cost= 200}
        };
        private readonly MovieDbContext _movieDbContext;

        public MovieRepository(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }
        public List<Movie> GetAllMovies()
        {
            return _movieDbContext.Movies.ToList(); 
        }

        Movie IMovieRepository.CreateMovie(Movie movie)
        {
            _movieDbContext.Movies.Add(movie);  
            _movieDbContext.SaveChanges();
            return movie;   
        }
    }
}
