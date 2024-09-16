---
sidebar_label: GetTopicsbyLearnerId
---

# CourseTopicRepository\.GetTopicsbyLearnerId\(Guid, Guid\) Method

**Containing Type**: [CourseTopicRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Threading.Tasks.Task<System.Collections.Generic.List<LXP.Common.Entities.LearnerProgress>> GetTopicsbyLearnerId(Guid courseId, Guid LearnerId)
```

### Parameters

**courseId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**LearnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[LearnerProgress](../../../../Common/Entities/LearnerProgress/index.md)&gt;&gt;

### Implements

* [ICourseTopicRepository.GetTopicsbyLearnerId](../../../IRepository/ICourseTopicRepository/GetTopicsbyLearnerId/index.md)
