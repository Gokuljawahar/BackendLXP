---
sidebar_label: GetTopicFeedbackResponsesByLearner
---

# FeedbackResponseDetailsRepository\.GetTopicFeedbackResponsesByLearner\(Guid, Guid\) Method

**Containing Type**: [FeedbackResponseDetailsRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Collections.Generic.List<LXP.Common.ViewModels.FeedbackResponseViewModel.TopicFeedbackResponseDetailsViewModel> GetTopicFeedbackResponsesByLearner(Guid topicId, Guid learnerId)
```

### Parameters

**topicId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[TopicFeedbackResponseDetailsViewModel](../../../../Common/ViewModels/FeedbackResponseViewModel/TopicFeedbackResponseDetailsViewModel/index.md)&gt;

### Implements

* [IFeedbackResponseDetailsRepository.GetTopicFeedbackResponsesByLearner](../../../IRepository/IFeedbackResponseDetailsRepository/GetTopicFeedbackResponsesByLearner/index.md)
