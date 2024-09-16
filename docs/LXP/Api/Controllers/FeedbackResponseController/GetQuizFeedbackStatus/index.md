---
sidebar_label: GetQuizFeedbackStatus
---

# FeedbackResponseController\.GetQuizFeedbackStatus\(Guid, Guid\) Method

**Containing Type**: [FeedbackResponseController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves the feedback status of a quiz for a specific learner\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("QuizFeedbackStatus")]
public Microsoft.AspNetCore.Mvc.IActionResult GetQuizFeedbackStatus(Guid learnerId, Guid quizId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the learner\.

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the quiz\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

A response containing the quiz feedback status for the learner\.

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

