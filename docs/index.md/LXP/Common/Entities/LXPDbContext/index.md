---
sidebar_label: LXPDbContext
---

# LXPDbContext Class

[Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Events](#events)

**Namespace**: [LXP.Common.Entities](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public class LXPDbContext : Microsoft.EntityFrameworkCore.DbContext
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext) &#x2192; LXPDbContext

### Implements

* [IAsyncDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.iasyncdisposable)
* [IDbContextDependencies](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.internal.idbcontextdependencies)
* [IDbContextPoolable](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.internal.idbcontextpoolable)
* [IDbSetCache](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.internal.idbsetcache)
* [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable)
* [IInfrastructure](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.infrastructure.iinfrastructure-1)&lt;[IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iserviceprovider)&gt;
* [IResettableService](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.infrastructure.iresettableservice)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [LXPDbContext()](-ctor/index.md#24848255) | |
| [LXPDbContext(DbContextOptions&lt;LXPDbContext&gt;)](-ctor/index.md#2768635545) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [ChangeTracker](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.changetracker) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [ContextId](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.contextid) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [CourseCategories](CourseCategories/index.md) | |
| [CourseFeedbackQuestions](CourseFeedbackQuestions/index.md) | |
| [CourseLevels](CourseLevels/index.md) | |
| [Courses](Courses/index.md) | |
| [Database](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.database) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Enrollments](Enrollments/index.md) | |
| [FeedbackQuestionsOptions](FeedbackQuestionsOptions/index.md) | |
| [FeedbackResponses](FeedbackResponses/index.md) | |
| [LearnerAnswers](LearnerAnswers/index.md) | |
| [LearnerAttempts](LearnerAttempts/index.md) | |
| [LearnerProfiles](LearnerProfiles/index.md) | |
| [LearnerProgresses](LearnerProgresses/index.md) | |
| [Learners](Learners/index.md) | |
| [Materials](Materials/index.md) | |
| [MaterialTypes](MaterialTypes/index.md) | |
| [Model](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.model) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [PasswordHistories](PasswordHistories/index.md) | |
| [QuestionOptions](QuestionOptions/index.md) | |
| [QuizFeedbackQuestions](QuizFeedbackQuestions/index.md) | |
| [QuizQuestions](QuizQuestions/index.md) | |
| [Quizzes](Quizzes/index.md) | |
| [TopicFeedbackQuestions](TopicFeedbackQuestions/index.md) | |
| [Topics](Topics/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [Add(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.add) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Add&lt;TEntity&gt;(TEntity)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.add) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [AddAsync(Object, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.addasync) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [AddAsync&lt;TEntity&gt;(TEntity, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.addasync) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [AddRange(IEnumerable&lt;Object&gt;)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.addrange) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [AddRange(Object\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.addrange) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [AddRangeAsync(IEnumerable&lt;Object&gt;, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.addrangeasync) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [AddRangeAsync(Object\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.addrangeasync) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Attach(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.attach) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Attach&lt;TEntity&gt;(TEntity)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.attach) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [AttachRange(IEnumerable&lt;Object&gt;)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.attachrange) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [AttachRange(Object\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.attachrange) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [ConfigureConventions(ModelConfigurationBuilder)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.configureconventions) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.dispose) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [DisposeAsync()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.disposeasync) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Entry(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.entry) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Entry&lt;TEntity&gt;(TEntity)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.entry) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.equals) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Find(Type, Object\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.find) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Find&lt;TEntity&gt;(Object\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.find) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [FindAsync(Type, Object\[\], CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.findasync) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [FindAsync(Type, Object\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.findasync) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [FindAsync&lt;TEntity&gt;(Object\[\], CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.findasync) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [FindAsync&lt;TEntity&gt;(Object\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.findasync) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [FromExpression&lt;TResult&gt;(Expression&lt;Func&lt;IQueryable&lt;TResult&gt;&gt;&gt;)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.fromexpression) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.gethashcode) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [OnConfiguring(DbContextOptionsBuilder)](OnConfiguring/index.md) |  \(Overrides [DbContext.OnConfiguring](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.onconfiguring)\) |
| [OnModelCreating(ModelBuilder)](OnModelCreating/index.md) |  \(Overrides [DbContext.OnModelCreating](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.onmodelcreating)\) |
| [Remove(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.remove) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Remove&lt;TEntity&gt;(TEntity)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.remove) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [RemoveRange(IEnumerable&lt;Object&gt;)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.removerange) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [RemoveRange(Object\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.removerange) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [SaveChanges()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.savechanges) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [SaveChanges(Boolean)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.savechanges) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [SaveChangesAsync(Boolean, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.savechangesasync) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [SaveChangesAsync(CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.savechangesasync) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Set&lt;TEntity&gt;()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.set) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Set&lt;TEntity&gt;(String)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.set) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.tostring) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Update(Object)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.update) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [Update&lt;TEntity&gt;(TEntity)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.update) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [UpdateRange(IEnumerable&lt;Object&gt;)](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.updaterange) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [UpdateRange(Object\[\])](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.updaterange) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |

## Events

| Event | Summary |
| ----- | ------- |
| [SaveChangesFailed](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.savechangesfailed) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [SavedChanges](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.savedchanges) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |
| [SavingChanges](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.savingchanges) |  \(Inherited from [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext)\) |

