---
sidebar_label: GetLearnerQuizStatusAsync
---

# QuizEngineRepository\.GetLearnerQuizStatusAsync\(Guid, Guid\) Method

**Containing Type**: [QuizEngineRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Threading.Tasks.Task<LXP.Common.ViewModels.QuizEngineViewModel.LearnerQuizStatusViewModel> GetLearnerQuizStatusAsync(Guid learnerId, Guid quizId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[LearnerQuizStatusViewModel](../../../../Common/ViewModels/QuizEngineViewModel/LearnerQuizStatusViewModel/index.md)&gt;

### Implements

* [IQuizEngineRepository.GetLearnerQuizStatusAsync](../../../IRepository/IQuizEngineRepository/GetLearnerQuizStatusAsync/index.md)
