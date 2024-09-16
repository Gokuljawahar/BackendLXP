---
sidebar_label: ConvertExcelToJson
---

# ExcelToJsonController\.ConvertExcelToJson\(IFormFile, Guid\) Method

**Containing Type**: [ExcelToJsonController](../index.md)

**Assembly**: LXP\.Api\.dll

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("ConvertExcelToJson")]
[Microsoft.AspNetCore.Mvc.ProducesResponseType(typeof(Microsoft.AspNetCore.Mvc.FileContentResult), 200)]
[Microsoft.AspNetCore.Mvc.ProducesResponseType(typeof(Microsoft.AspNetCore.Mvc.BadRequestObjectResult), 400)]
[Microsoft.AspNetCore.Mvc.ProducesResponseType(typeof(Microsoft.AspNetCore.Mvc.ObjectResult), 500)]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> ConvertExcelToJson(Microsoft.AspNetCore.Http.IFormFile file, Guid quizId)
```

### Parameters

**file** &ensp; [IFormFile](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.iformfile)

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)
* [ProducesResponseTypeAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.producesresponsetypeattribute)
* [ProducesResponseTypeAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.producesresponsetypeattribute)
* [ProducesResponseTypeAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.producesresponsetypeattribute)

