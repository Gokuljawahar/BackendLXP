---
sidebar_label: GetLearnerQuizStatus
---

# QuizEngineController\.GetLearnerQuizStatus\(Guid, Guid\) Method

**Containing Type**: [QuizEngineController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves the status of a quiz for a specific learner\. for frontend

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("learner/{learnerId}/quiz/{quizId}/status")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<LXP.Common.ViewModels.QuizEngineViewModel.LearnerQuizStatusViewModel>> GetLearnerQuizStatus(Guid learnerId, Guid quizId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the learner\.

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the quiz\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[ActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.actionresult-1)&lt;[LearnerQuizStatusViewModel](../../../../Common/ViewModels/QuizEngineViewModel/LearnerQuizStatusViewModel/index.md)&gt;&gt;

A response containing the quiz status for the learner\.

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

