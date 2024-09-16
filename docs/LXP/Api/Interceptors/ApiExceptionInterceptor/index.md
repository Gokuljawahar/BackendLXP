---
sidebar_label: ApiExceptionInterceptor
---

# ApiExceptionInterceptor Class

[Remarks](#remarks) &#x2022; [Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Api.Interceptors](../index.md)

**Assembly**: LXP\.Api\.dll

  
API Exception Interceptor

```csharp
public class ApiExceptionInterceptor : Microsoft.AspNetCore.Mvc.Filters.IAsyncExceptionFilter
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; ApiExceptionInterceptor

### Implements

* [IAsyncExceptionFilter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.filters.iasyncexceptionfilter)
* [IFilterMetadata](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.filters.ifiltermetadata)

## Remarks

Constructor

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [ApiExceptionInterceptor(ILogger&lt;ApiExceptionInterceptor&gt;)](-ctor/index.md) | API Exception Interceptor |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [OnExceptionAsync(ExceptionContext)](OnExceptionAsync/index.md) | On Exception Implementation \(Implements [IAsyncExceptionFilter.OnExceptionAsync](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.filters.iasyncexceptionfilter.onexceptionasync)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

