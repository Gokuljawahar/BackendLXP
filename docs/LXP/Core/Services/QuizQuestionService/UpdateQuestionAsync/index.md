---
sidebar_label: UpdateQuestionAsync
---

# QuizQuestionService\.UpdateQuestionAsync\(Guid, QuizQuestionViewModel, List&lt;QuestionOptionViewModel&gt;\) Method

**Containing Type**: [QuizQuestionService](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public System.Threading.Tasks.Task<bool> UpdateQuestionAsync(Guid quizQuestionId, QuizQuestionViewModel quizQuestion, System.Collections.Generic.List<QuestionOptionViewModel> options)
```

### Parameters

**quizQuestionId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**quizQuestion** &ensp; QuizQuestionViewModel

**options** &ensp; [List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;QuestionOptionViewModel&gt;

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)&gt;

### Implements

* [IQuizQuestionService.UpdateQuestionAsync](../../../IServices/IQuizQuestionService/UpdateQuestionAsync/index.md)
