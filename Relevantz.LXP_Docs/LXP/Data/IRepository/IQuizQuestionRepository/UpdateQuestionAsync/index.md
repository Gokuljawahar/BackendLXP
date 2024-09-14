---
sidebar_label: UpdateQuestionAsync
---

# IQuizQuestionRepository\.UpdateQuestionAsync\(Guid, QuizQuestionViewModel, List&lt;QuestionOptionViewModel&gt;\) Method

**Containing Type**: [IQuizQuestionRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
System.Threading.Tasks.Task<bool> UpdateQuestionAsync(Guid quizQuestionId, LXP.Common.ViewModels.QuizQuestionViewModel.QuizQuestionViewModel quizQuestion, System.Collections.Generic.List<LXP.Common.ViewModels.QuizQuestionViewModel.QuestionOptionViewModel> options)
```

### Parameters

**quizQuestionId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**quizQuestion** &ensp; [QuizQuestionViewModel](../../../../Common/ViewModels/QuizQuestionViewModel/QuizQuestionViewModel/index.md)

**options** &ensp; [List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[QuestionOptionViewModel](../../../../Common/ViewModels/QuizQuestionViewModel/QuestionOptionViewModel/index.md)&gt;

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)&gt;

