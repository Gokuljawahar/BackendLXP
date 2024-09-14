---
sidebar_label: Updatecourse
---

# CourseController\.Updatecourse\(CourseUpdateModel\) Method

**Containing Type**: [CourseController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Update the course

```csharp
[Microsoft.AspNetCore.Mvc.HttpPut("lxp/courseupdate")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> Updatecourse(LXP.Common.ViewModels.CourseUpdateModel course)
```

### Parameters

**course** &ensp; [CourseUpdateModel](../../../../Common/ViewModels/CourseUpdateModel/index.md)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpPutAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpputattribute)

