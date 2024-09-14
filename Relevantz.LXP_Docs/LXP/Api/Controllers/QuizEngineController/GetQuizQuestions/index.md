---
sidebar_label: GetQuizQuestions
---

# QuizEngineController\.GetQuizQuestions\(Guid\) Method

**Containing Type**: [QuizEngineController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves questions for a specific quiz by its ID\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("quiz/{quizId}/questions")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetQuizQuestions(Guid quizId)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the quiz\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

