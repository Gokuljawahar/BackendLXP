---
sidebar_label: DeleteEnrollment
---

# EnrollmentController\.DeleteEnrollment\(Guid\) Method

**Containing Type**: [EnrollmentController](../index.md)

**Assembly**: LXP\.Api\.dll

```csharp
[Microsoft.AspNetCore.Mvc.HttpDelete("lxp/enroll/delete/{enrollmentId}")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeleteEnrollment(Guid enrollmentId)
```

### Parameters

**enrollmentId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpDeleteAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpdeleteattribute)

