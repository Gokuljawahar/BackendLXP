using LXP.Common.Entities;
using LXP.Common.ViewModels.CourseFeedbackQuestionViewModel;

namespace LXP.Data.IRepository
{
    public interface ICourseFeedbackRepository
    {
        void AddFeedbackQuestion(Coursefeedbackquestion coursefeedbackquestion);
        void AddFeedbackQuestionOptions(List<Feedbackquestionsoption> options);
        List<CourseFeedbackQuestionNoViewModel> GetAllFeedbackQuestions();
        CourseFeedbackQuestionNoViewModel GetFeedbackQuestionById(Guid courseFeedbackQuestionId);
        Coursefeedbackquestion GetCourseFeedbackQuestionEntityById(Guid courseFeedbackQuestionId);
        void UpdateFeedbackQuestion(Coursefeedbackquestion coursefeedbackquestion);
        List<Feedbackquestionsoption> GetFeedbackQuestionOptionsById(Guid courseFeedbackQuestionId);
        void RemoveFeedbackQuestionOptions(List<Feedbackquestionsoption> options);
        void DeleteFeedbackQuestion(Coursefeedbackquestion coursefeedbackquestion);
        List<CourseFeedbackQuestionNoViewModel> GetFeedbackQuestionsByCourseId(Guid courseId);
        int GetNextFeedbackQuestionNo(Guid courseId);
    }
}
