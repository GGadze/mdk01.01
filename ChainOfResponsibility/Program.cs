﻿using ChainOfResponsibility.Validators;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailValidator emailValidator = new EmailValidator();
            PasswordValidator passwordValidator = new PasswordValidator();
            LoginValidator loginValidator = new LoginValidator();

            User user = new User
            {
                Login = "54234236",
                Password = "passworddgdgвава46545!",
                Email = "testemail@mail.ru"
            };

            loginValidator.SetNextValidator(emailValidator);
            emailValidator.SetNextValidator(passwordValidator);

            loginValidator.Validate(user);
        }
    }
}
