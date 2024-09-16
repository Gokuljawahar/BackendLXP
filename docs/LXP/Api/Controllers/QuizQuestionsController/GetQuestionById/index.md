---
sidebar_label: GetQuestionById
---

# QuizQuestionsController\.GetQuestionById\(Guid\) Method

**Containing Type**: [QuizQuestionsController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieve a quiz question by its ID\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("GetQuestionById")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetQuestionById(Guid quizQuestionId)
```

### Parameters

**quizQuestionId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the quiz question\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

