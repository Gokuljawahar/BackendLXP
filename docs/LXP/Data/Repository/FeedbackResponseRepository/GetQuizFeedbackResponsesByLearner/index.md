---
sidebar_label: GetQuizFeedbackResponsesByLearner
---

# FeedbackResponseRepository\.GetQuizFeedbackResponsesByLearner\(Guid, Guid\) Method

**Containing Type**: [FeedbackResponseRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Collections.Generic.IEnumerable<LXP.Common.Entities.FeedbackResponse> GetQuizFeedbackResponsesByLearner(Guid learnerId, Guid quizId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;[FeedbackResponse](../../../../Common/Entities/FeedbackResponse/index.md)&gt;

### Implements

* [IFeedbackResponseRepository.GetQuizFeedbackResponsesByLearner](../../../IRepository/IFeedbackResponseRepository/GetQuizFeedbackResponsesByLearner/index.md)
