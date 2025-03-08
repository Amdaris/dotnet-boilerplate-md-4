using Microsoft.AspNetCore.Mvc;

using System;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge2 : ControllerBase
    {
        [HttpPost("challenge-2")]
        public int[] Implementation([FromBody] int[] array)
        {
            // Write the code for Challenge 2 here

            throw new NotImplementedException();
        }
    }
}
