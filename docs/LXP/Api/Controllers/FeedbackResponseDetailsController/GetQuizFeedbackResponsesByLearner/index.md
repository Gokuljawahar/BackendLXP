---
sidebar_label: GetQuizFeedbackResponsesByLearner
---

# FeedbackResponseDetailsController\.GetQuizFeedbackResponsesByLearner\(Guid, Guid\) Method

**Containing Type**: [FeedbackResponseDetailsController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves feedback responses for a specific quiz and learner by their IDs\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("quiz/{quizId}/learner/{learnerId}")]
public Microsoft.AspNetCore.Mvc.IActionResult GetQuizFeedbackResponsesByLearner(Guid quizId, Guid learnerId)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the quiz\.

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the learner\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

