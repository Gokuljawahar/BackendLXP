---
sidebar_label: GetAllQuestionsByQuizIdAsync
---

# QuizQuestionRepository\.GetAllQuestionsByQuizIdAsync\(Guid\) Method

**Containing Type**: [QuizQuestionRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Threading.Tasks.Task<System.Collections.Generic.List<LXP.Common.ViewModels.QuizQuestionViewModel.QuizQuestionNoViewModel>> GetAllQuestionsByQuizIdAsync(Guid quizId)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[QuizQuestionNoViewModel](../../../../Common/ViewModels/QuizQuestionViewModel/QuizQuestionNoViewModel/index.md)&gt;&gt;

### Implements

* [IQuizQuestionRepository.GetAllQuestionsByQuizIdAsync](../../../IRepository/IQuizQuestionRepository/GetAllQuestionsByQuizIdAsync/index.md)
