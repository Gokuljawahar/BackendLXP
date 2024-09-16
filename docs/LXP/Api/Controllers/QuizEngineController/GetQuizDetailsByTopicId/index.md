---
sidebar_label: GetQuizDetailsByTopicId
---

# QuizEngineController\.GetQuizDetailsByTopicId\(Guid\) Method

**Containing Type**: [QuizEngineController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves quiz details by topic ID\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("topic/{topicId}/quiz")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetQuizDetailsByTopicId(Guid topicId)
```

### Parameters

**topicId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the topic\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

