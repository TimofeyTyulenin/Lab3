using Lab3.Utils;

namespace Lab3.Models {
    public class QuizAnswerModel {
        [LessThanOrNull(101, ErrorMessage = "слишком большое число!")]
        public int? Answer { get; set; }
    }
}
