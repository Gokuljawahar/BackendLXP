---
sidebar_label: GetQuizById
---

# QuizController\.GetQuizById\(Guid\) Method

**Containing Type**: [QuizController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves a specific quiz by its ID\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("{quizId}")]
public Microsoft.AspNetCore.Mvc.IActionResult GetQuizById(Guid quizId)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the quiz to retrieve\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

