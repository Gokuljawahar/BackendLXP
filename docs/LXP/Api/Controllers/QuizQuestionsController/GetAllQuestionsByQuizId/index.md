---
sidebar_label: GetAllQuestionsByQuizId
---

# QuizQuestionsController\.GetAllQuestionsByQuizId\(Guid\) Method

**Containing Type**: [QuizQuestionsController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieve all quiz questions for a specific quiz\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("GetAllQuestionsByQuizId")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetAllQuestionsByQuizId(Guid quizId)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the quiz\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

