using Microsoft.AspNetCore.Mvc;

namespace modul10_103022300050.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private static readonly List<Movies> movies = new()
        {
            new Movies ("The Shawshank Redemption", "Frank Darabont", ["Tim Robbins", "Morgan Freeman", "Bob Gunton"], "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movies ("The Godfather", "Francis Ford Coppola", ["Marlon Brando", "Al Pacino", "James Caan"], "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movies ("The Dark Knight", "Christopher Nolan", ["Christian Bale", "Heath Ledger", "Aaron Eckhart"], "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness."),
        };

        [HttpGet]
        public ActionResult<IEnumerable<Movies>> GetAllMovie() 
        {
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movies> GetMovieById(int id)
        {
            if (id < 0 || id >= movies.Count)
            {
                return NotFound(new { message = "Id Movie tidak ditemukan"});
            }

            return Ok(movies[id]);
        }

        [HttpPost]
        public ActionResult PostMovies([FromBody] Movies movie)
        {
            movies.Add(movie);
            return Ok(new {message = "Movie berhasil ditambahkan", id = movies.Count -1});
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMovieById(int id)
        {
            movies.RemoveAt(id);
            return Ok(new {message = "Movie berhasil dihapus"});
        }
    }
}
