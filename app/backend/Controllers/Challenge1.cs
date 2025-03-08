using Microsoft.AspNetCore.Mvc;

using System;

namespace backend.Controllers
{
    [ApiController]
    public class Challenge1 : ControllerBase
    {
        [HttpPost("challenge-1")]
        public bool Implementation([FromBody] int[] array)
        {
            // Write the code for Challenge 1 here

            throw new NotImplementedException();
        }
    }
}
