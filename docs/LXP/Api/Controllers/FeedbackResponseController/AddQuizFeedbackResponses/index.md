---
sidebar_label: AddQuizFeedbackResponses
---

# FeedbackResponseController\.AddQuizFeedbackResponses\(IEnumerable&lt;QuizFeedbackResponseViewModel&gt;\) Method

**Containing Type**: [FeedbackResponseController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Adds new quiz feedback responses\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("AddQuizFeedbackResponses")]
public Microsoft.AspNetCore.Mvc.IActionResult AddQuizFeedbackResponses(System.Collections.Generic.IEnumerable<QuizFeedbackResponseViewModel> feedbackResponses)
```

### Parameters

**feedbackResponses** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;QuizFeedbackResponseViewModel&gt;

The list of quiz feedback response models\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

A response indicating the result of the feedback submission\.

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

