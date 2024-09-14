---
sidebar_label: GetMaterialByMaterialId
---

# MaterialController\.GetMaterialByMaterialId\(String\) Method

**Containing Type**: [MaterialController](../index.md)

**Assembly**: LXP\.Api\.dll

  
 getting the particular material using materialId

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("/lxp/course/material/{materialId}")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetMaterialByMaterialId(string materialId)
```

### Parameters

**materialId** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

