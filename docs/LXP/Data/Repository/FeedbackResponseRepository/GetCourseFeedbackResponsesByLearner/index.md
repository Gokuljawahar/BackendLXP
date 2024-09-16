---
sidebar_label: GetCourseFeedbackResponsesByLearner
---

# FeedbackResponseRepository\.GetCourseFeedbackResponsesByLearner\(Guid, Guid\) Method

**Containing Type**: [FeedbackResponseRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Collections.Generic.IEnumerable<LXP.Common.Entities.FeedbackResponse> GetCourseFeedbackResponsesByLearner(Guid learnerId, Guid courseId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**courseId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;[FeedbackResponse](../../../../Common/Entities/FeedbackResponse/index.md)&gt;

### Implements

* [IFeedbackResponseRepository.GetCourseFeedbackResponsesByLearner](../../../IRepository/IFeedbackResponseRepository/GetCourseFeedbackResponsesByLearner/index.md)
