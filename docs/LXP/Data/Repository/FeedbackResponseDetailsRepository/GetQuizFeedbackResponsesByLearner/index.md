---
sidebar_label: GetQuizFeedbackResponsesByLearner
---

# FeedbackResponseDetailsRepository\.GetQuizFeedbackResponsesByLearner\(Guid, Guid\) Method

**Containing Type**: [FeedbackResponseDetailsRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Collections.Generic.List<LXP.Common.ViewModels.FeedbackResponseViewModel.QuizFeedbackResponseDetailsViewModel> GetQuizFeedbackResponsesByLearner(Guid quizId, Guid learnerId)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[QuizFeedbackResponseDetailsViewModel](../../../../Common/ViewModels/FeedbackResponseViewModel/QuizFeedbackResponseDetailsViewModel/index.md)&gt;

### Implements

* [IFeedbackResponseDetailsRepository.GetQuizFeedbackResponsesByLearner](../../../IRepository/IFeedbackResponseDetailsRepository/GetQuizFeedbackResponsesByLearner/index.md)
