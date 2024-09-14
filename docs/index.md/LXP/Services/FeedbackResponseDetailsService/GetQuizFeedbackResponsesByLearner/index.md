---
sidebar_label: GetQuizFeedbackResponsesByLearner
---

# FeedbackResponseDetailsService\.GetQuizFeedbackResponsesByLearner\(Guid, Guid\) Method

**Containing Type**: [FeedbackResponseDetailsService](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public System.Collections.Generic.List<LXP.Common.ViewModels.FeedbackResponseViewModel.QuizFeedbackResponseDetailsViewModel> GetQuizFeedbackResponsesByLearner(Guid quizId, Guid learnerId)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[QuizFeedbackResponseDetailsViewModel](../../../Common/ViewModels/FeedbackResponseViewModel/QuizFeedbackResponseDetailsViewModel/index.md)&gt;

### Implements

* [IFeedbackResponseDetailsService.GetQuizFeedbackResponsesByLearner](../../IServices/IFeedbackResponseDetailsService/GetQuizFeedbackResponsesByLearner/index.md)
