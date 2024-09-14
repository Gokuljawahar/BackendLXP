---
sidebar_label: GetMaterialProgress
---

# LearnerProgressController\.GetMaterialProgress\(Guid, Guid\) Method

**Containing Type**: [LearnerProgressController](../index.md)

**Assembly**: LXP\.Api\.dll

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("{materialId}/progress/{learnerId}")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<double>> GetMaterialProgress(Guid materialId, Guid learnerId)
```

### Parameters

**materialId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[ActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.actionresult-1)&lt;[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)&gt;&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

