﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS_DotNet02_Online_Naumenko.Logic.Interfaces;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService ?? throw new ArgumentNullException(nameof(postService));
        }

        [HttpGet]
        public IEnumerable<PostDTO> Get()
        {
            var result =  _postService.GetAllPosts();

            return result;
        }
    }
}
