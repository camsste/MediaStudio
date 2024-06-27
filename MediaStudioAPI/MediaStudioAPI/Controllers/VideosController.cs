using Microsoft.AspNetCore.Mvc;
using MediaStudioAPI.Models;
using System;
using System.Collections.Generic;

namespace MediaStudioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private static List<Video> _videos = new List<Video>();

        // GET: api/videos
        [HttpGet]
        public IEnumerable<Video> Get()
        {
            return _videos;
        }

        // GET: api/videos/{id}
        [HttpGet("{id}")]
        public ActionResult<Video> Get(int id)
        {
            var video = _videos.Find(v => v.Id == id);
            if (video == null)
            {
                return NotFound();
            }
            return video;
        }

        // POST: api/videos
        [HttpPost]
        public ActionResult<Video> Post([FromBody] Video video)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            video.Id = _videos.Count + 1; // Simulação de ID automático
            _videos.Add(video);

            return CreatedAtAction(nameof(Get), new { id = video.Id }, video);
        }

        // PUT: api/videos/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Video video)
        {
            var existingVideo = _videos.Find(v => v.Id == id);
            if (existingVideo == null)
            {
                return NotFound();
            }

            existingVideo.Title = video.Title;
            existingVideo.Director = video.Director;
            existingVideo.Year = video.Year;
            existingVideo.Price = video.Price;

            return NoContent();
        }

        // DELETE: api/videos/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var videoToRemove = _videos.Find(v => v.Id == id);
            if (videoToRemove == null)
            {
                return NotFound();
            }

            _videos.Remove(videoToRemove);

            return NoContent();
        }
    }
}
