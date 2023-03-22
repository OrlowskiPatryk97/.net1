using System.ComponentModel.DataAnnotations;
namespace FizzBuzzWeb.Forms
{
    public class FizzBuzzForm
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required]
        [Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakredu {1} i {2}.")]
        public int? Number { get; set; }
        public string? Name { get; set; }

        public string? output() {
            if (Number % 3 == 0 && Number % 5 != 0)
            { return "Fizz"; }
            if (Number % 3 != 0 && Number % 5 == 0)
            { return "Buzz"; }
            if (Number % 3 == 0 && Number % 5 == 0)
            { return "FizzBuzz"; }
            else
            return "Liczba:" +Number+" nie spełnia kryteriów FizzBuzz";
        }
    }
}
