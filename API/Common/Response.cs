using System;

namespace API.Common;

public class Response<T>
{
  public bool IsSuccess { get; }

  public T Data { get; }
  public string? Error{ get; }

  public string? Message { get; set; }
public Response(bool isSuccess, T data, string? error, string? message)
{
  IsSuccess = isSuccess;
  Error = error;
  Data = data;
  Message = message;

}
public static Response<T> Success(T data, string? message = "")=>
new (true, data, null, message);

public static Response<T> Failure(string error)=>
new (false, default!, error, null);
 


}
