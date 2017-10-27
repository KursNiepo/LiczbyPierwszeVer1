using System.ComponentModel.DataAnnotations;
using System.Web.Services.Description;

namespace LiczbyPierwszeVer_1.Models
{
    public class GenList
    {
        [Required(ErrorMessage = "Podaj liczbę")]
        [Range(2,100,ErrorMessage = "Liczba z przedziału 2 do 100")]
        [Display(Name = "Podaj ilość powtórzeń")]
        public int Quantity { get; set; }

        [Display(Name = "Podaj tekst do wyświetlenia")]
        [Required(ErrorMessage = "Podaj Tekst")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
    }
}