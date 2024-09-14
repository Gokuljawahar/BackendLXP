---
sidebar_label: GetQuestionsForQuizAsync
---

# QuizEngineRepository\.GetQuestionsForQuizAsync\(Guid\) Method

**Containing Type**: [QuizEngineRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<LXP.Common.ViewModels.QuizEngineViewModel.QuizEngineQuestionViewModel>> GetQuestionsForQuizAsync(Guid quizId)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;[QuizEngineQuestionViewModel](../../../../Common/ViewModels/QuizEngineViewModel/QuizEngineQuestionViewModel/index.md)&gt;&gt;

### Implements

* [IQuizEngineRepository.GetQuestionsForQuizAsync](../../../IRepository/IQuizEngineRepository/GetQuestionsForQuizAsync/index.md)
