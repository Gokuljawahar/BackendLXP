using LXP.Common.Entities;
using LXP.Common.ViewModels.QuizQuestionViewModel;
using LXP.Data.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LXP.Data.Repository
{
    public class QuizQuestionRepository : IQuizQuestionRepository
    {
        private readonly LXPDbContext _LXPDbContext;

        public QuizQuestionRepository(LXPDbContext dbContext)
        {
            _LXPDbContext =
                dbContext
                ?? throw new ArgumentNullException(nameof(dbContext), "DB context cannot be null.");
        }

        public async Task<Guid> AddQuestionAsync(
            QuizQuestionViewModel quizQuestion,
            List<QuestionOptionViewModel> options
        )
        {
            var quizQuestionEntity = new QuizQuestion
            {
                QuizId = quizQuestion.QuizId,
                Question = quizQuestion.Question,
                QuestionType = quizQuestion.QuestionType,
                QuestionNo = await GetNextQuestionNoAsync(quizQuestion.QuizId),
                CreatedBy = "SystemUser",
                CreatedAt = DateTime.Now
            };

            await _LXPDbContext.QuizQuestions.AddAsync(quizQuestionEntity);
            await _LXPDbContext.SaveChangesAsync();

            foreach (var option in options)
            {
                var questionOptionEntity = new QuestionOption
                {
                    QuizQuestionId = quizQuestionEntity.QuizQuestionId,
                    Option = option.Option,
                    IsCorrect = option.IsCorrect,
                    CreatedBy = "SystemUser",
                    CreatedAt = DateTime.Now
                };

                await _LXPDbContext.QuestionOptions.AddAsync(questionOptionEntity);
            }

            await _LXPDbContext.SaveChangesAsync();

            return quizQuestionEntity.QuizQuestionId;
        }

        public async Task<bool> UpdateQuestionAsync(
            Guid quizQuestionId,
            QuizQuestionViewModel quizQuestion,
            List<QuestionOptionViewModel> options
        )
        {
            var quizQuestionEntity = await _LXPDbContext.QuizQuestions.FindAsync(quizQuestionId);
            if (quizQuestionEntity == null)
                return false;

            quizQuestionEntity.Question = quizQuestion.Question;

            var existingOptions = _LXPDbContext
                .QuestionOptions.Where(o => o.QuizQuestionId == quizQuestionId)
                .ToList();
            _LXPDbContext.QuestionOptions.RemoveRange(existingOptions);

            foreach (var option in options)
            {
                var questionOptionEntity = new QuestionOption
                {
                    QuizQuestionId = quizQuestionEntity.QuizQuestionId,
                    Option = option.Option,
                    IsCorrect = option.IsCorrect,
                    CreatedBy = quizQuestionEntity.CreatedBy,
                    CreatedAt = quizQuestionEntity.CreatedAt
                };

                await _LXPDbContext.QuestionOptions.AddAsync(questionOptionEntity);
            }

            await _LXPDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteQuestionAsync(Guid quizQuestionId)
        {
            var quizQuestionEntity = await _LXPDbContext.QuizQuestions.FindAsync(quizQuestionId);
            if (quizQuestionEntity == null)
                return false;

            _LXPDbContext.QuestionOptions.RemoveRange(
                _LXPDbContext.QuestionOptions.Where(o => o.QuizQuestionId == quizQuestionId)
            );
            _LXPDbContext.QuizQuestions.Remove(quizQuestionEntity);
            await _LXPDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<List<QuizQuestionNoViewModel>> GetAllQuestionsAsync()
        {
            return await _LXPDbContext
                .QuizQuestions.Select(q => new QuizQuestionNoViewModel
                {
                    QuizId = q.QuizId,
                    QuizQuestionId = q.QuizQuestionId,
                    Question = q.Question,
                    QuestionType = q.QuestionType,
                    QuestionNo = q.QuestionNo,
                    Options = _LXPDbContext
                        .QuestionOptions.Where(o => o.QuizQuestionId == q.QuizQuestionId)
                        .Select(o => new QuestionOptionViewModel
                        {
                            Option = o.Option,
                            IsCorrect = o.IsCorrect
                        })
                        .ToList()
                })
                .ToListAsync();
        }

        public async Task<List<QuizQuestionNoViewModel>> GetAllQuestionsByQuizIdAsync(Guid quizId)
        {
            return await _LXPDbContext
                .QuizQuestions.Where(q => q.QuizId == quizId)
                .Select(q => new QuizQuestionNoViewModel
                {
                    QuizId = q.QuizId,
                    QuizQuestionId = q.QuizQuestionId,
                    Question = q.Question,
                    QuestionType = q.QuestionType,
                    QuestionNo = q.QuestionNo,
                    Options = _LXPDbContext
                        .QuestionOptions.Where(o => o.QuizQuestionId == q.QuizQuestionId)
                        .Select(o => new QuestionOptionViewModel
                        {
                            Option = o.Option,
                            IsCorrect = o.IsCorrect
                        })
                        .ToList()
                })
                .ToListAsync();
        }

        public async Task<QuizQuestionNoViewModel> GetQuestionByIdAsync(Guid quizQuestionId)
        {
            var quizQuestion = await _LXPDbContext
                .QuizQuestions.Where(q => q.QuizQuestionId == quizQuestionId)
                .Select(q => new
                {
                    q.QuizId,
                    q.QuizQuestionId,
                    q.Question,
                    q.QuestionType,
                    q.QuestionNo,
                    Options = _LXPDbContext
                        .QuestionOptions.Where(o => o.QuizQuestionId == q.QuizQuestionId)
                        .Select(o => new QuestionOptionViewModel
                        {
                            Option = o.Option,
                            IsCorrect = o.IsCorrect
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();

            if (quizQuestion == null)
            {
                return null;
            }

            return new QuizQuestionNoViewModel
            {
                QuizId = quizQuestion.QuizId,
                QuizQuestionId = quizQuestion.QuizQuestionId,
                Question = quizQuestion.Question,
                QuestionType = quizQuestion.QuestionType,
                QuestionNo = quizQuestion.QuestionNo,
                Options = quizQuestion.Options ?? new List<QuestionOptionViewModel>()
            };
        }

        public async Task<int> GetNextQuestionNoAsync(Guid quizId)
        {
            int count = await _LXPDbContext
                .QuizQuestions.Where(q => q.QuizId == quizId)
                .CountAsync();
            return count + 1;
        }

        public void ReorderQuestionNos(Guid quizId, int deletedQuestionNo)
        {
            var subsequentQuestions = _LXPDbContext
                .QuizQuestions.Where(q => q.QuizId == quizId && q.QuestionNo > deletedQuestionNo)
                .ToList();
            foreach (var question in subsequentQuestions)
            {
                question.QuestionNo--;
            }
            _LXPDbContext.SaveChanges();
        }
    }
}


