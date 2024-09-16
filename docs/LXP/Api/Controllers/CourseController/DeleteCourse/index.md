---
sidebar_label: DeleteCourse
---

# CourseController\.DeleteCourse\(Guid\) Method

**Containing Type**: [CourseController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Delete the course

```csharp
[Microsoft.AspNetCore.Mvc.HttpDelete("/lxp/coursedelete/{id}")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeleteCourse(Guid id)
```

### Parameters

**id** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpDeleteAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpdeleteattribute)

