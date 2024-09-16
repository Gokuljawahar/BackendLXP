---
sidebar_label: SubmitQuizAttempt
---

# QuizEngineController\.SubmitQuizAttempt\(Guid\) Method

**Containing Type**: [QuizEngineController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Submits a quiz attempt by its ID\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("attempt/submit")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> SubmitQuizAttempt(Guid attemptId)
```

### Parameters

**attemptId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the quiz attempt\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

