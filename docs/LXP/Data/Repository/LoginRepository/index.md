---
sidebar_label: LoginRepository
---

# LoginRepository Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Data.Repository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public class LoginRepository : LXP.Data.IRepository.ILoginRepository
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; LoginRepository

### Implements

* [ILoginRepository](../../IRepository/ILoginRepository/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [LoginRepository(LXPDbContext)](-ctor/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [AnyLearnerByEmailAndPassword(String, String)](AnyLearnerByEmailAndPassword/index.md) |  \(Implements [ILoginRepository.AnyLearnerByEmailAndPassword](../../IRepository/ILoginRepository/AnyLearnerByEmailAndPassword/index.md)\) |
| [AnyUserByEmail(String)](AnyUserByEmail/index.md) |  \(Implements [ILoginRepository.AnyUserByEmail](../../IRepository/ILoginRepository/AnyUserByEmail/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetLearnerByEmail(String)](GetLearnerByEmail/index.md) |  \(Implements [ILoginRepository.GetLearnerByEmail](../../IRepository/ILoginRepository/GetLearnerByEmail/index.md)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [LoginLearner(Learner)](LoginLearner/index.md) |  \(Implements [ILoginRepository.LoginLearner](../../IRepository/ILoginRepository/LoginLearner/index.md)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [UpdateLearnerLastLogin(String)](UpdateLearnerLastLogin/index.md) |  \(Implements [ILoginRepository.UpdateLearnerLastLogin](../../IRepository/ILoginRepository/UpdateLearnerLastLogin/index.md)\) |
| [UpdateLearnerPassword(String, String)](UpdateLearnerPassword/index.md) |  \(Implements [ILoginRepository.UpdateLearnerPassword](../../IRepository/ILoginRepository/UpdateLearnerPassword/index.md)\) |

