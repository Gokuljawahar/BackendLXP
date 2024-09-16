---
sidebar_label: AddQuestionAsync
---

# QuizQuestionService\.AddQuestionAsync\(QuizQuestionViewModel, List&lt;QuestionOptionViewModel&gt;\) Method

**Containing Type**: [QuizQuestionService](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public System.Threading.Tasks.Task<Guid> AddQuestionAsync(LXP.Common.ViewModels.QuizQuestionViewModel.QuizQuestionViewModel quizQuestion, System.Collections.Generic.List<LXP.Common.ViewModels.QuizQuestionViewModel.QuestionOptionViewModel> options)
```

### Parameters

**quizQuestion** &ensp; [QuizQuestionViewModel](../../../../Common/ViewModels/QuizQuestionViewModel/QuizQuestionViewModel/index.md)

**options** &ensp; [List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[QuestionOptionViewModel](../../../../Common/ViewModels/QuizQuestionViewModel/QuestionOptionViewModel/index.md)&gt;

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)&gt;

### Implements

* [IQuizQuestionService.AddQuestionAsync](../../../IServices/IQuizQuestionService/AddQuestionAsync/index.md)
