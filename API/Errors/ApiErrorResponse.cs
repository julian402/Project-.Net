using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Errors;

public class ApiErrorResponse(int statusCode, string message, string? details)
{
    public int StatusCode { get; set; } = statusCode;
    public string Message { get; set; } = message;

    public string? Details { get; set; } = details;
}
