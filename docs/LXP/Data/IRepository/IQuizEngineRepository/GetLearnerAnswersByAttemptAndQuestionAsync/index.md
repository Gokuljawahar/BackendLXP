---
sidebar_label: GetLearnerAnswersByAttemptAndQuestionAsync
---

# IQuizEngineRepository\.GetLearnerAnswersByAttemptAndQuestionAsync\(Guid, Guid\) Method

**Containing Type**: [IQuizEngineRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<LXP.Common.ViewModels.QuizEngineViewModel.LearnerAnswerViewModel>> GetLearnerAnswersByAttemptAndQuestionAsync(Guid attemptId, Guid quizQuestionId)
```

### Parameters

**attemptId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**quizQuestionId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;[LearnerAnswerViewModel](../../../../Common/ViewModels/QuizEngineViewModel/LearnerAnswerViewModel/index.md)&gt;&gt;

