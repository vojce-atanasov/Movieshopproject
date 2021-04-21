using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Movieshop.Entities;
using Movieshop.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movieshop.API
{
    [Route("api/MovieAPI")]
    [ApiController]
    public class MovieAPIController : ControllerBase
    {
        //private readonly IMovieService _movieService;
        //private ILogger<MovieAPIController> _logger;

        //public MovieAPIController(IMovieService movieService, ILogger<MovieAPIController> logger)
        //{
        //    _movieService = movieService;
        //    _logger = logger;
        //}

        //[HttpGet("MoviesData")]
        //public IEnumerable<Movie> GetMoviesFullData()
        //{
        //    var movies = _movieService.GetAllMovies();
        //    return movies.AsEnumerable();
        //}

        //[HttpGet("Movies")]
        //public IEnumerable<MovieApiDTO> GetMovies()
        //{
        //    var movies = _movieService.GetAllMoviesAPI();
        //    return movies;
        //}

    }
}
