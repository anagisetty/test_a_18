using System;
using System.Linq;
using System.Collections.Generic;
using Test_A_18.DTO;
using Test_A_18.DataAccess;

namespace Test_A_18
{
    public class SignUpService
    {
        SignUpRepository _signupRepository;

        public SignUpService(SignUpRepository signupRepository)
        {
            _signupRepository = signupRepository;
        }

        // Create
        public void CreateSignUp(SignUp signup)
        {
            _signupRepository.Create(signup);
        }

        // Read
        public List<SignUp> GetAllSignUps()
        {
            return _signupRepository.GetAll();
        }

        public SignUp GetSignUpById(int id)
        {
            return _signupRepository.GetById(id);
        }

        // Update
        public void UpdateSignUp(SignUp signup)
        {
            _signupRepository.Update(signup);
        }

        // Delete
        public void DeleteSignUp(int id)
        {
            _signupRepository.Delete(id);
        }
    }
}