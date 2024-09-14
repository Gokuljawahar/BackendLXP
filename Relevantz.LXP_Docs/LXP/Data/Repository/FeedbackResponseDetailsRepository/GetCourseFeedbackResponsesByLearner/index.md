---
sidebar_label: GetCourseFeedbackResponsesByLearner
---

# FeedbackResponseDetailsRepository\.GetCourseFeedbackResponsesByLearner\(Guid, Guid\) Method

**Containing Type**: [FeedbackResponseDetailsRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Collections.Generic.List<LXP.Common.ViewModels.FeedbackResponseViewModel.CourseFeedbackResponseDetailsViewModel> GetCourseFeedbackResponsesByLearner(Guid courseId, Guid learnerId)
```

### Parameters

**courseId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[CourseFeedbackResponseDetailsViewModel](../../../../Common/ViewModels/FeedbackResponseViewModel/CourseFeedbackResponseDetailsViewModel/index.md)&gt;

### Implements

* [IFeedbackResponseDetailsRepository.GetCourseFeedbackResponsesByLearner](../../../IRepository/IFeedbackResponseDetailsRepository/GetCourseFeedbackResponsesByLearner/index.md)
