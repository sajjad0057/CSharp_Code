namespace Collection_Examples
{
    public class Test
    {
        public string Id { get; set; } = string.Empty;
    }


    public class HubResponse<T>
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string ResponseMessage { get; set; } = string.Empty;
        public T? Data { get; set; } = default(T?);

        public static HubResponse<T> Ok(int statusCode, string message, T? data = default(T)) =>
            new() { Success = true, StatusCode = statusCode, ResponseMessage = message, Data = data };

        public static HubResponse<T> Fail(int statusCode, string message, T? data = default(T)) =>
            new() { Success = false, ResponseMessage = message, Data = default(T) };
    }
}
