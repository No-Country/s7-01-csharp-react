namespace s7_01.Api.Common.DTO
{
    public class ResponseDTO
    {
        public bool Success { get; set; }
        public object Result { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }

    }
}
