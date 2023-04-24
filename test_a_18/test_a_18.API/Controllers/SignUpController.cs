using System;
using System.Linq;
using System.Collections.Generic;
using Test_A_18.DTO;
using Test_A_18.DataAccess;
using Test_A_18.Service;
using Microsoft.AspNetCore.Mvc;

namespace Test_A_18.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        private readonly SignUpService _signupService;

        public SignUpController(SignUpService signupService)
        {
            _signupService = signupService;
        }

        // Create
        [HttpPost]
        public void CreateSignUp([FromBody] SignUp signup)
        {
            _signupService.CreateSignUp(signup);
        }

        // Read
        [HttpGet]
        public ActionResult<List<SignUp>> GetAllSignUps()
        {
            return _signupService.GetAllSignUps();
        }

        [HttpGet("{id}")]
        public ActionResult<SignUp> GetSignUpById(int id)
        {
            var signup = _signupService.GetSignUpById(id);

            if (signup == null)
            {
                return NotFound();
            }

            return signup;
        }

        // Update
        [HttpPut("{id}")]
        public ActionResult<SignUp> UpdateSignUp(int id, [FromBody] SignUp signup)
        {
            if (id != signup.Id)
            {
                return BadRequest();
            }

            _signupService.UpdateSignUp(signup);

            return signup;
        }

        // Delete
        [HttpDelete("{id}")]
        public ActionResult<SignUp> DeleteSignUp(int id)
        {
            var signup = _signupService.GetSignUpById(id);

            if (signup == null)
            {
                return NotFound();
            }

            _signupService.DeleteSignUp(id);

            return signup;
        }
    }

}