using System.ComponentModel.DataAnnotations;

namespace BlazorTrainingMai22.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage="bitte füllen")]
        [StringLength(10, ErrorMessage = "max 10 Zeichen")]
        public string Name { get; set; }
        [Required(ErrorMessage = "bitte füllen")]
        [Range(100,190, ErrorMessage = "Größe zwischne 100 und 190cm")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "bitte füllen")]
        public DateTime GebDat { get; set; }
    }
}
