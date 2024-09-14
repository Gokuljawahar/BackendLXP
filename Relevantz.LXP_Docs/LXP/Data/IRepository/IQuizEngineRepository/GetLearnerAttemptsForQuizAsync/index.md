---
sidebar_label: GetLearnerAttemptsForQuizAsync
---

# IQuizEngineRepository\.GetLearnerAttemptsForQuizAsync\(Guid, Guid\) Method

**Containing Type**: [IQuizEngineRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<LXP.Common.ViewModels.QuizEngineViewModel.LearnerAttemptViewModel>> GetLearnerAttemptsForQuizAsync(Guid learnerId, Guid quizId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;[LearnerAttemptViewModel](../../../../Common/ViewModels/QuizEngineViewModel/LearnerAttemptViewModel/index.md)&gt;&gt;

