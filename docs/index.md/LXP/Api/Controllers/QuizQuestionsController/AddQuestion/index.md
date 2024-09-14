---
sidebar_label: AddQuestion
---

# QuizQuestionsController\.AddQuestion\(QuizQuestionViewModel\) Method

**Containing Type**: [QuizQuestionsController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Add a new quiz question\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("AddQuestion")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> AddQuestion(LXP.Common.ViewModels.QuizQuestionViewModel.QuizQuestionViewModel quizQuestion)
```

### Parameters

**quizQuestion** &ensp; [QuizQuestionViewModel](../../../../Common/ViewModels/QuizQuestionViewModel/QuizQuestionViewModel/index.md)

The details of the quiz question to add\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

