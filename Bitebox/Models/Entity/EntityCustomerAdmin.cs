namespace Bitebox.Models.Entity
{
    public class EntityCustomerAdmin
    { // ini anu di stter juga
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string NamaLengkap { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsAktif { get; set; }
    }
}