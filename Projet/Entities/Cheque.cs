using System.ComponentModel.DataAnnotations;

namespace Projet.Entities
{
    public class Cheque
    {

        public int Id { get; set; }
        [Required]
        public string? Numero { get; set; }
        [Required]
        public string? Montant { get; set; }


    }
}
