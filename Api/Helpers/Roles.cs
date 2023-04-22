namespace s7_01.Api.Helpers
{
    public class Roles
    {
        public enum Role
        {
            Admin,
            User,
            Veterinaria
        }

        public const Role rol_predeterminado = Role.User;
    }
}
