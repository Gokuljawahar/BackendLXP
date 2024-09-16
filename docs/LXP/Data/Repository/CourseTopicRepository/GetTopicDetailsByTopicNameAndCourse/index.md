---
sidebar_label: GetTopicDetailsByTopicNameAndCourse
---

# CourseTopicRepository\.GetTopicDetailsByTopicNameAndCourse\(String, Guid\) Method

**Containing Type**: [CourseTopicRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Threading.Tasks.Task<LXP.Common.Entities.Topic> GetTopicDetailsByTopicNameAndCourse(string topicName, Guid courseId)
```

### Parameters

**topicName** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**courseId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[Topic](../../../../Common/Entities/Topic/index.md)&gt;

### Implements

* [ICourseTopicRepository.GetTopicDetailsByTopicNameAndCourse](../../../IRepository/ICourseTopicRepository/GetTopicDetailsByTopicNameAndCourse/index.md)
