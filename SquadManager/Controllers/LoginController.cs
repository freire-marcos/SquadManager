using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;
using SquadManager.Validator;

namespace SquadManager.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();

            UserValidator validator = new UserValidator();
            ValidationResult validationResult = validator.Validate(user);

            if (!validationResult.IsValid)
            {
                foreach (var item in validationResult.Errors)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Propriedade {item.PropertyName} failed validation.{item.ErrorMessage}");
                }
            }
            return View("index", user);
        }

        [HttpPost]
        public IActionResult Test(UserViewModel user)
        {
            user.Email = "test";
            return View("index", user);
        }

    }
}
