using Microsoft.AspNetCore.Http;

namespace Generics_Examples
{
    public sealed class ApiResults<T>
    {
        public bool IsSuccess { get; init; }
        public int StatusCode { get; init; }
        public T? Data { get; init; }
        public string[] Errors { get; init; } = Array.Empty<string>();

        public static ApiResults<T> Success() => new()
        {
            IsSuccess = true,
            StatusCode = StatusCodes.Status200OK,
            Data = default(T)
        };

        public static ApiResults<T> Success(int statusCode, T data) => new()
        {
            IsSuccess = statusCode is >= 200 and < 300,
            StatusCode = statusCode,
            Data = data
        };

        public static ApiResults<T> Fail(int statusCode, params string[] errors) => new()
        {
            IsSuccess = statusCode is >= 200 and < 300,
            StatusCode = statusCode,
            Data = default(T),
            Errors = errors
        };
    }
}
