namespace s7_01.Api.Common.Exceptions
{
    public class ServicioExceptions : Exception
    {
        public ServicioExceptions(string mensaje, Exception ex) : base(mensaje, ex)
        {

        }
    }
}
