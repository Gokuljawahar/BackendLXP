---
sidebar_label: DeleteQuestion
---

# QuizQuestionsController\.DeleteQuestion\(Guid\) Method

**Containing Type**: [QuizQuestionsController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Delete a quiz question\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpDelete("DeleteQuestion")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeleteQuestion(Guid quizQuestionId)
```

### Parameters

**quizQuestionId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the quiz question to delete\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpDeleteAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpdeleteattribute)

