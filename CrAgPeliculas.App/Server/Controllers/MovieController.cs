using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CrAgPeliculas.App.Shared.Entity; 
using CrAgPeliculas.App.Server.Helpers;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CrAgPeliculas.App.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly AppContext context;
        private readonly IFileStore filestore;
        private readonly string container = "MoviePosters";

        public MovieController(AppContext context, IFileStore filestore)
        {
            this.filestore = filestore;
            this.context = context; 
        }
        
        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            var posterMovie = Convert.FromBase64String(movie.Poster);
            movie.Poster = await filestore.SaveFile(posterMovie, ".jpg", container);

            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }

        [HttpGet]
        public async Task<ActionResult<List<Movie>>> Get()
        {
            var Movies = await context.MovieTB.ToListAsync();
            return Movies;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> Get(int id)
        {
            var movie = await context.MovieTB.Where(m => m.Id == id).FirstOrDefaultAsync();

            if(movie == null) 
            {
                return NotFound();
            }
            else
            {
                return new Movie()
                {
                    Title = movie.Title,
                    Year = movie.Year,
                    Backdrop = movie.Backdrop,
                    Poster = movie.Poster,
                    Overview = movie.Overview,
                    Score = movie.Score,
                    Trailer = movie.Trailer
                };
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(Movie movie)
        {
            context.Attach(movie).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}