---
sidebar_label: UpdateMaterial
---

# MaterialController\.UpdateMaterial\(MaterialUpdateViewModel\) Method

**Containing Type**: [MaterialController](../index.md)

**Assembly**: LXP\.Api\.dll

  
 updating the material

```csharp
[Microsoft.AspNetCore.Mvc.HttpPut("/lxp/course/material")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateMaterial(LXP.Common.ViewModels.MaterialUpdateViewModel material)
```

### Parameters

**material** &ensp; [MaterialUpdateViewModel](../../../../Common/ViewModels/MaterialUpdateViewModel/index.md)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpPutAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpputattribute)

