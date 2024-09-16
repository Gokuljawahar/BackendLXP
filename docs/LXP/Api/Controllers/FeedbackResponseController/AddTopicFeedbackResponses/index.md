---
sidebar_label: AddTopicFeedbackResponses
---

# FeedbackResponseController\.AddTopicFeedbackResponses\(IEnumerable&lt;TopicFeedbackResponseViewModel&gt;\) Method

**Containing Type**: [FeedbackResponseController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Adds new topic feedback responses\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("AddTopicFeedbackResponses")]
public Microsoft.AspNetCore.Mvc.IActionResult AddTopicFeedbackResponses(System.Collections.Generic.IEnumerable<TopicFeedbackResponseViewModel> feedbackResponses)
```

### Parameters

**feedbackResponses** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;TopicFeedbackResponseViewModel&gt;

The list of topic feedback response models\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

A response indicating the result of the feedback submission\.

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

