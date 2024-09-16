---
sidebar_label: GetPassStatus
---

# QuizEngineController\.GetPassStatus\(Guid\) Method

**Containing Type**: [QuizEngineController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves the pass status of a specific learner by their attempt ID\. for forntend

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("learner/{learnerAttemptId}/passstatus")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetPassStatus(Guid learnerAttemptId)
```

### Parameters

**learnerAttemptId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the learner's attempt to retrieve\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

