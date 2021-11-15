using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Homework2.Models
{
    public class FormModel
    {
        public int _counter;

        [Display(Name = "Imię")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Ilość powtórzeń")]
        public int Counter 
        { 
            get => _counter;
            set
            {
                if (value > 5 || value <= 0)
                    throw new System.ArgumentOutOfRangeException();
                else
                    _counter = value;
            }
        }
    }
}
