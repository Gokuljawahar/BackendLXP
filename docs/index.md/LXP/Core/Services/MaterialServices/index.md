---
sidebar_label: MaterialServices
---

# MaterialServices Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Core.Services](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public class MaterialServices : LXP.Core.IServices.IMaterialServices
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; MaterialServices

### Implements

* [IMaterialServices](../../IServices/IMaterialServices/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [MaterialServices(IMaterialTypeRepository, IMaterialRepository, ICourseTopicRepository, IWebHostEnvironment, IHttpContextAccessor)](-ctor/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [AddMaterial(MaterialViewModel)](AddMaterial/index.md) |  \(Implements [IMaterialServices.AddMaterial](../../IServices/IMaterialServices/AddMaterial/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetAllMaterialDetailsByTopicAndType(String, String)](GetAllMaterialDetailsByTopicAndType/index.md) |  \(Implements [IMaterialServices.GetAllMaterialDetailsByTopicAndType](../../IServices/IMaterialServices/GetAllMaterialDetailsByTopicAndType/index.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetMaterialByMaterialNameAndTopic(String, String)](GetMaterialByMaterialNameAndTopic/index.md) |  \(Implements [IMaterialServices.GetMaterialByMaterialNameAndTopic](../../IServices/IMaterialServices/GetMaterialByMaterialNameAndTopic/index.md)\) |
| [GetMaterialDetailsByMaterialId(String)](GetMaterialDetailsByMaterialId/index.md) |  \(Implements [IMaterialServices.GetMaterialDetailsByMaterialId](../../IServices/IMaterialServices/GetMaterialDetailsByMaterialId/index.md)\) |
| [GetMaterialDetailsByMaterialIdWithoutPDFConversionForUpdate(String)](GetMaterialDetailsByMaterialIdWithoutPDFConversionForUpdate/index.md) |  \(Implements [IMaterialServices.GetMaterialDetailsByMaterialIdWithoutPDFConversionForUpdate](../../IServices/IMaterialServices/GetMaterialDetailsByMaterialIdWithoutPDFConversionForUpdate/index.md)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [SoftDeleteMaterial(String)](SoftDeleteMaterial/index.md) |  \(Implements [IMaterialServices.SoftDeleteMaterial](../../IServices/IMaterialServices/SoftDeleteMaterial/index.md)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [UpdateMaterial(MaterialUpdateViewModel)](UpdateMaterial/index.md) |  \(Implements [IMaterialServices.UpdateMaterial](../../IServices/IMaterialServices/UpdateMaterial/index.md)\) |

