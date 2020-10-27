using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Поле 'Имя' не заполнено!")]
        [StringLength(30, ErrorMessage = "Имя пользователя слишком длинное")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле 'Фамилия' не заполнено!")]
        [StringLength(30, ErrorMessage = "Фамилия пользователя слишком длинная")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Поле 'Email' не заполнено!")]
        [EmailAddress(ErrorMessage = "Введен не корректный Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле 'Пароль' не заполнено!")]
        [StringLength(50, ErrorMessage = "Пароль должен быть длиной от 6 до 50 символов!", MinimumLength = 6)]
        public string Password { get; set; }
        public string NameImg { get; set; }
        public string PathImg { get; set; }
    }
}
