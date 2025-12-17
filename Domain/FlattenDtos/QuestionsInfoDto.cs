using System;
using Domain.Enumerations;

namespace Domain.FlattenDtos
{
    public record QuestionsInfoDto(Guid Id, Guid QuestionId, Guid BriefInfoId, QuestionType Type)
    {
        public Guid Id { get; set; } = Id;
        public Guid QuestionId { get; set; } = QuestionId;
        public Guid BriefInfoId { get; set; } = BriefInfoId;
        public QuestionType Type { get; set; } = Type;
    }
}