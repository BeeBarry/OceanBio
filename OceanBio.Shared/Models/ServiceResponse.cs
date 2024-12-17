namespace OceanBio.Shared.Models;

public class ServiceResponse<T>
{
    public T? Data { get; set; }
    public bool IsSuccess { get; set; }
    public string? Message { get; set; } = string.Empty;

    public static ServiceResponse<T> Success(T data)
    {
        return new ServiceResponse<T> { IsSuccess = true, Data = data };
    }

    public static ServiceResponse<T> Fail(string message)
    {
        return new ServiceResponse<T> { IsSuccess = false, Message = message };
    }
    
}