namespace Unified_DevOps_Hub.Class
{
    public class Użytkownicy
    {
        public int Id_Użytkownika {  get; set; }
        public string Imie {  get; set; }
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public DateTime Data_Urodzenia { get; set; }
        public string? Miejscowosc { get; set; }
        public string? Dział { get; set; }
        public string Email { get; set; }

    }
}