using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CommentApi.Models;
using CommentApi.Repository;

namespace CommentApi.Controllers
{
    [Route("api/[controller]")]
    public class CommentController : Controller
    {
        private CommentRepository CommentRepository = new CommentRepository();

        [HttpGet]
        public IEnumerable<Comment> GetAlls()
        {
            return CommentRepository.GetAlls();
        }
        [HttpGet("{id}", Name = "GetComment")]
        public IActionResult GetByIdComment(int id)
        {
            var item = CommentRepository.Get(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPost]
        public IActionResult Create([FromBody] Comment item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            CommentRepository.Add(item);
            return CreatedAtRoute("GetComment", new { Controller = "Comment", id = item.IdComment }, item);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Comment item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            
            CommentRepository.Update(item);
            return new NoContentResult();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            CommentRepository.Delete(id);
        }

    }
}