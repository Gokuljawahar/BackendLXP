---
sidebar_label: StartQuizAttempt
---

# QuizEngineController\.StartQuizAttempt\(Guid, Guid\) Method

**Containing Type**: [QuizEngineController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Starts a quiz attempt for a learner\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("attempt")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> StartQuizAttempt(Guid learnerId, Guid quizId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the learner\.

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the quiz\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

