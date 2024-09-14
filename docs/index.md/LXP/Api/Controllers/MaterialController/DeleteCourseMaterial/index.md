---
sidebar_label: DeleteCourseMaterial
---

# MaterialController\.DeleteCourseMaterial\(String\) Method

**Containing Type**: [MaterialController](../index.md)

**Assembly**: LXP\.Api\.dll

  
 deleting the material using materialId

```csharp
[Microsoft.AspNetCore.Mvc.HttpDelete("/lxp/course/material/{materialId}")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeleteCourseMaterial(string materialId)
```

### Parameters

**materialId** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpDeleteAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpdeleteattribute)

