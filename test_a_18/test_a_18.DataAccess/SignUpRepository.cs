using System;
using System.Linq;
using System.Collections.Generic;
using Test_A_18.DTO;

namespace Test_A_18
{
    public class SignUpRepository
    {
        // Create
        public void Create(SignUp signup)
        {
            // Logic to create a signup
        }

        // Read
        public List<SignUp> GetAll()
        {
            List<SignUp> signups = new List<SignUp>();
            // Logic to get all signups
            return signups;
        }

        public SignUp GetById(int id)
        {
            SignUp signup = new SignUp();

            // Logic to get signup by Id
            return signup;
        }

        // Update
        public void Update(SignUp signup)
        {
            // Logic to update signup
        }

        // Delete
        public void Delete(int id)
        {
            // Logic to delete signup
        }
    }
}