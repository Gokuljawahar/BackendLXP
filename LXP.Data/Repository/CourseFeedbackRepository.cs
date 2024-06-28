using LXP.Common.Entities;
using LXP.Common.ViewModels.CourseFeedbackQuestionViewModel;
using LXP.Data.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LXP.Data.Repository
{
    public class CourseFeedbackRepository : ICourseFeedbackRepository
    {
        private readonly LXPDbContext _context;

        public CourseFeedbackRepository(LXPDbContext context)
        {
            _context = context;
        }

        public void AddFeedbackQuestion(Coursefeedbackquestion coursefeedbackquestion)
        {
            _context.Coursefeedbackquestions.Add(coursefeedbackquestion);
            _context.SaveChanges();
        }

        public void AddFeedbackQuestionOptions(List<Feedbackquestionsoption> options)
        {
            _context.Feedbackquestionsoptions.AddRange(options);
            _context.SaveChanges();
        }

        public List<CourseFeedbackQuestionNoViewModel> GetAllFeedbackQuestions()
        {
            var feedbackQuestions = _context
                .Coursefeedbackquestions.Include(q => q.Feedbackquestionsoptions)
                .ToList();

            return feedbackQuestions
                .Select(q => new CourseFeedbackQuestionNoViewModel
                {
                    CourseFeedbackQuestionId = q.CourseFeedbackQuestionId,
                    CourseId = q.CourseId,
                    QuestionNo = q.QuestionNo,
                    Question = q.Question,
                    QuestionType = q.QuestionType,
                    Options = q
                        .Feedbackquestionsoptions?.Select(
                            o => new CourseFeedbackQuestionsOptionViewModel
                            {
                                OptionText = o.OptionText
                            }
                        )
                        .ToList()
                })
                .ToList();
        }

        public CourseFeedbackQuestionNoViewModel GetFeedbackQuestionById(
            Guid courseFeedbackQuestionId
        )
        {
            var question = _context
                .Coursefeedbackquestions.Include(q => q.Feedbackquestionsoptions)
                .FirstOrDefault(q => q.CourseFeedbackQuestionId == courseFeedbackQuestionId);

            if (question == null)
            {
                return null;
            }

            return new CourseFeedbackQuestionNoViewModel
            {
                CourseFeedbackQuestionId = question.CourseFeedbackQuestionId,
                CourseId = question.CourseId,
                QuestionNo = question.QuestionNo,
                Question = question.Question,
                QuestionType = question.QuestionType,
                Options = question
                    .Feedbackquestionsoptions?.Select(
                        o => new CourseFeedbackQuestionsOptionViewModel
                        {
                            OptionText = o.OptionText
                        }
                    )
                    .ToList()
            };
        }

        public Coursefeedbackquestion GetCourseFeedbackQuestionEntityById(
            Guid courseFeedbackQuestionId
        )
        {
            return _context
                .Coursefeedbackquestions.Include(q => q.Feedbackquestionsoptions)
                .FirstOrDefault(q => q.CourseFeedbackQuestionId == courseFeedbackQuestionId);
        }

        public void UpdateFeedbackQuestion(Coursefeedbackquestion coursefeedbackquestion)
        {
            _context.Coursefeedbackquestions.Update(coursefeedbackquestion);
            _context.SaveChanges();
        }

        public List<Feedbackquestionsoption> GetFeedbackQuestionOptionsById(
            Guid courseFeedbackQuestionId
        )
        {
            return _context
                .Feedbackquestionsoptions.Where(o =>
                    o.CourseFeedbackQuestionId == courseFeedbackQuestionId
                )
                .ToList();
        }

        public void RemoveFeedbackQuestionOptions(List<Feedbackquestionsoption> options)
        {
            _context.Feedbackquestionsoptions.RemoveRange(options);
            _context.SaveChanges();
        }

        public void DeleteFeedbackQuestion(Coursefeedbackquestion coursefeedbackquestion)
        {
            _context.Coursefeedbackquestions.Remove(coursefeedbackquestion);
            _context.SaveChanges();
        }

        public List<CourseFeedbackQuestionNoViewModel> GetFeedbackQuestionsByCourseId(Guid courseId)
        {
            var feedbackQuestions = _context
                .Coursefeedbackquestions.Where(q => q.CourseId == courseId)
                .Include(q => q.Feedbackquestionsoptions)
                .ToList();

            return feedbackQuestions
                .Select(q => new CourseFeedbackQuestionNoViewModel
                {
                    CourseFeedbackQuestionId = q.CourseFeedbackQuestionId,
                    CourseId = q.CourseId,
                    QuestionNo = q.QuestionNo,
                    Question = q.Question,
                    QuestionType = q.QuestionType,
                    Options = q
                        .Feedbackquestionsoptions?.Select(
                            o => new CourseFeedbackQuestionsOptionViewModel
                            {
                                OptionText = o.OptionText
                            }
                        )
                        .ToList()
                })
                .ToList();
        }

        public int GetNextFeedbackQuestionNo(Guid courseId)
        {
            return _context
                    .Coursefeedbackquestions.Where(q => q.CourseId == courseId)
                    .Max(q => (int?)q.QuestionNo) + 1
                ?? 1;
        }
    }
}
