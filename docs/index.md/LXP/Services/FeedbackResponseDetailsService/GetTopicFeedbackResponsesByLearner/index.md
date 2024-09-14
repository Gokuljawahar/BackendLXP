---
sidebar_label: GetTopicFeedbackResponsesByLearner
---

# FeedbackResponseDetailsService\.GetTopicFeedbackResponsesByLearner\(Guid, Guid\) Method

**Containing Type**: [FeedbackResponseDetailsService](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public System.Collections.Generic.List<LXP.Common.ViewModels.FeedbackResponseViewModel.TopicFeedbackResponseDetailsViewModel> GetTopicFeedbackResponsesByLearner(Guid topicId, Guid learnerId)
```

### Parameters

**topicId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[TopicFeedbackResponseDetailsViewModel](../../../Common/ViewModels/FeedbackResponseViewModel/TopicFeedbackResponseDetailsViewModel/index.md)&gt;

### Implements

* [IFeedbackResponseDetailsService.GetTopicFeedbackResponsesByLearner](../../IServices/IFeedbackResponseDetailsService/GetTopicFeedbackResponsesByLearner/index.md)
