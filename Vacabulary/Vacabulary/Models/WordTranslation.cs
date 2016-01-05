
namespace Vacabulary.Models
{
    public struct WordTranslation
    {
        public readonly string SourceWord;
        public readonly string DestWord;

        public WordTranslation(string sourceWord, string destWord)
        {
            SourceWord = sourceWord;
            DestWord = destWord;
        }
    }
}