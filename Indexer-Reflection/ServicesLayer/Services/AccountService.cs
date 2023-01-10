using ServicesLayer.Exceptions;
using ServicesLayer.Helpers;
using ServicesLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Services
{
    public class AccountService:IAccountService
    {

        public string Register(string username, string email, string password)
        {
            try
            {
                var result = GetAll();
                if (result.Contains(email))
                {
                    throw new RegisterExceptions(ResponseMessages.InvalidRgisterMessage);
                }
                return ResponseMessages.SuccesRgisterMessage;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        private List<string> GetAll()
        {
            return new List<string>() { "jeyhun@code.edu.az", "konulsi@code.edu.az", "Shaig@code.edu.az" };
        }

    }
}
