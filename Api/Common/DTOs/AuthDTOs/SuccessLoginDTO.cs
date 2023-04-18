using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Common.DTOs.AuthDTOs
{
    public class SuccessLoginDTO
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public int IdRole { get; set; }
        public Role Role { get; set; }
    }
}
