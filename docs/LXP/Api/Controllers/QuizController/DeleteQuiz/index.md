---
sidebar_label: DeleteQuiz
---

# QuizController\.DeleteQuiz\(Guid\) Method

**Containing Type**: [QuizController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Deletes a quiz by its ID\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpDelete("{quizId}")]
public Microsoft.AspNetCore.Mvc.IActionResult DeleteQuiz(Guid quizId)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the quiz to delete\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpDeleteAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpdeleteattribute)

