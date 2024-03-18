using CleanAr.Application.Blogs.Commands.CreateBlog;
using CleanAr.Application.Blogs.Queries.GetBlogById;
using CleanAr.Application.Blogs.Queries.GetBlogs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanAr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAsync() 
        {

            var blogs = await Mediator.Send(new GetBlogQuery());
            return Ok(blogs);
        
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyId(int id) {

            var blog = await Mediator.Send(new GetBlogByIdQuery() { BlogId = id });
            if (blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateBlogCommand command) {

            var createBlog=await Mediator.Send(command);
            return CreatedAtAction(nameof(GetbyId),new {id =createBlog.Id},createBlog);
          

        }

        
        

       
    }
}
