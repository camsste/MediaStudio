using Microsoft.AspNetCore.Mvc;
using MediaStudioAPI.Models;
using System;
using System.Collections.Generic;

namespace MediaStudioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private static List<Album> _albums = new List<Album>();

        // GET: api/albums
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return _albums;
        }

        // GET: api/albums/{id}
        [HttpGet("{id}")]
        public ActionResult<Album> Get(int id)
        {
            var album = _albums.Find(a => a.Id == id);
            if (album == null)
            {
                return NotFound();
            }
            return album;
        }

        // POST: api/albums
        [HttpPost]
        public ActionResult<Album> Post([FromBody] Album album)
        {
            if (!album.IsValid())
            {
                return BadRequest("Título e Artista são obrigatórios.");
            }

            album.Id = _albums.Count + 1; // Simulação de ID automático
            _albums.Add(album);

            return CreatedAtAction(nameof(Get), new { id = album.Id }, album);
        }

        // PUT: api/albums/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Album album)
        {
            var existingAlbum = _albums.Find(a => a.Id == id);
            if (existingAlbum == null)
            {
                return NotFound();
            }

            existingAlbum.Title = album.Title;
            existingAlbum.Artist = album.Artist;
            existingAlbum.Year = album.Year;
            existingAlbum.Price = album.Price;

            return NoContent();
        }

        // DELETE: api/albums/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var albumToRemove = _albums.Find(a => a.Id == id);
            if (albumToRemove == null)
            {
                return NotFound();
            }

            _albums.Remove(albumToRemove);

            return NoContent();
        }
    }
}
