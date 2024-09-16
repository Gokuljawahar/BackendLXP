---
sidebar_label: UpdateQuestion
---

# QuizQuestionsController\.UpdateQuestion\(Guid, QuizQuestionViewModel\) Method

**Containing Type**: [QuizQuestionsController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Update an existing quiz question\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpPut("UpdateQuestion")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateQuestion(Guid quizQuestionId, QuizQuestionViewModel quizQuestion)
```

### Parameters

**quizQuestionId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the quiz question to update\.

**quizQuestion** &ensp; QuizQuestionViewModel

The updated details of the quiz question\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpPutAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpputattribute)

