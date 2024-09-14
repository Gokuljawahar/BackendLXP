---
sidebar_label: CheckLearnerPassStatusAsync
---

# QuizEngineService\.CheckLearnerPassStatusAsync\(Guid\) Method

**Containing Type**: [QuizEngineService](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public System.Threading.Tasks.Task<LXP.Common.ViewModels.QuizEngineViewModel.LearnerPassStatusViewModel> CheckLearnerPassStatusAsync(Guid learnerAttemptId)
```

### Parameters

**learnerAttemptId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[LearnerPassStatusViewModel](../../../../Common/ViewModels/QuizEngineViewModel/LearnerPassStatusViewModel/index.md)&gt;

### Implements

* [IQuizEngineService.CheckLearnerPassStatusAsync](../../../IServices/IQuizEngineService/CheckLearnerPassStatusAsync/index.md)
