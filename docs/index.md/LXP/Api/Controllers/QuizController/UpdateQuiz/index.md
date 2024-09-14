---
sidebar_label: UpdateQuiz
---

# QuizController\.UpdateQuiz\(Guid, UpdateQuizViewModel\) Method

**Containing Type**: [QuizController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Updates an existing quiz\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpPut("{quizId}")]
public Microsoft.AspNetCore.Mvc.IActionResult UpdateQuiz(Guid quizId, LXP.Common.ViewModels.QuizViewModel.UpdateQuizViewModel request)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the quiz to update\.

**request** &ensp; [UpdateQuizViewModel](../../../../Common/ViewModels/QuizViewModel/UpdateQuizViewModel/index.md)

Data representing the updated quiz properties, provided in the request body\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpPutAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpputattribute)

