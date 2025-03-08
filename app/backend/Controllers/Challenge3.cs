using Microsoft.AspNetCore.Mvc;

using System;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge3 : ControllerBase
    {
        [HttpPost("challenge-3")]
        public int Implementation([FromBody] int[] array)
        {
            // Write the code for Challenge 3 here

            throw new NotImplementedException();
        }
    }
}
