﻿using CleanAr.Application.Blogs.Queries.GetBlogs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanAr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAsync() {


            var blogs = await Mediator.Send(new GetBlogQuery());
            return Ok(blogs);
        
        }
    }
}
