---
sidebar_label: CreateQuiz
---

# QuizController\.CreateQuiz\(CreateQuizViewModel\) Method

**Containing Type**: [QuizController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Creates a new quiz\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost]
public Microsoft.AspNetCore.Mvc.IActionResult CreateQuiz(LXP.Common.ViewModels.QuizViewModel.CreateQuizViewModel request)
```

### Parameters

**request** &ensp; [CreateQuizViewModel](../../../../Common/ViewModels/QuizViewModel/CreateQuizViewModel/index.md)

Data representing the new quiz to be created, provided in the request body\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

