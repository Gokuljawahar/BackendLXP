---
sidebar_label: SendEmailAsync
---

# EmailService\.SendEmailAsync\(String, String, String\) Method

**Containing Type**: [EmailService](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public System.Threading.Tasks.Task<bool> SendEmailAsync(string recipientEmail, string subject, string body)
```

### Parameters

**recipientEmail** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**subject** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**body** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)&gt;

### Implements

* [IEmailService.SendEmailAsync](../../../IServices/IEmailService/SendEmailAsync/index.md)
