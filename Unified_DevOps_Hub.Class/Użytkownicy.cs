using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unified_DevOps_Hub.Class
{
    public class Użytkownicy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Użytkownika {  get; set; }

        public string Imie {  get; set; }

        public string Nazwisko { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }

        public DateTime Data_Urodzenia { get; set; }

        public string? Miejscowosc { get; set; }

        public string? Dział { get; set; }

        public string Email { get; set; }

    }
}