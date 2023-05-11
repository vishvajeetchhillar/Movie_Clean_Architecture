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
