---
sidebar_label: GetQuizFeedbackResponses
---

# FeedbackResponseDetailsController\.GetQuizFeedbackResponses\(Guid\) Method

**Containing Type**: [FeedbackResponseDetailsController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves feedback responses for a specific quiz by its ID\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("quiz/{quizId}")]
public Microsoft.AspNetCore.Mvc.IActionResult GetQuizFeedbackResponses(Guid quizId)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the quiz\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

