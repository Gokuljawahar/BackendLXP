---
sidebar_label: GetLearnerQuizAttemptResult
---

# QuizEngineController\.GetLearnerQuizAttemptResult\(Guid\) Method

**Containing Type**: [QuizEngineController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves the result of a specific quiz attempt by its ID\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("attempts/{attemptId}/result")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetLearnerQuizAttemptResult(Guid attemptId)
```

### Parameters

**attemptId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the quiz attempt\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

