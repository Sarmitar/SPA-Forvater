using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



//Класс с моделями и требованием символов валидации
namespace SPAForvater1.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Пожалуйста введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите свой Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Вы ввели некоректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите свой телефон")]
        public string Phone { get; set; }
        public string Comment { get; set; }

        [Required(ErrorMessage = "Пожалуйста укажите, в какое время суток вам удобнее получить звонок")]
        public bool? TimeOfDay { get; set; } 

    }
}