---
sidebar_label: CreateLearnerAttemptAsync
---

# QuizEngineRepository\.CreateLearnerAttemptAsync\(Guid, Guid, DateTime\) Method

**Containing Type**: [QuizEngineRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Threading.Tasks.Task<LXP.Common.ViewModels.QuizEngineViewModel.LearnerAttemptViewModel?> CreateLearnerAttemptAsync(Guid learnerId, Guid quizId, DateTime startTime)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**startTime** &ensp; [DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[LearnerAttemptViewModel](../../../../Common/ViewModels/QuizEngineViewModel/LearnerAttemptViewModel/index.md)&gt;

### Implements

* [IQuizEngineRepository.CreateLearnerAttemptAsync](../../../IRepository/IQuizEngineRepository/CreateLearnerAttemptAsync/index.md)
