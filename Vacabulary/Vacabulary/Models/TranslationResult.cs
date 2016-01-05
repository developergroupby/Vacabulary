using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vacabulary.Models
{
    public class TranslationResult
    {
        public readonly bool Success;

        public readonly string SourceLanguage;
        public readonly string DestLanguage;
        public IEnumerable<WordTranslation> WordTranslations { get; private set; }

        public readonly string Error;

        private TranslationResult(bool success, string sourceLang, string destLang, IEnumerable<WordTranslation> translations, string error)
        {
            if (success && (string.IsNullOrEmpty(sourceLang) || string.IsNullOrEmpty(destLang) || translations == null))
            {
                throw new ArgumentException();
            }

            Success = success;
            SourceLanguage = sourceLang;
            DestLanguage = destLang;
            WordTranslations = translations;
            Error = error;
        }

        public static TranslationResult SuccessResult(string sourceLang, string destLang, IEnumerable<WordTranslation> translations)
        {
            return new TranslationResult(true, sourceLang, destLang, translations, null);
        }

        public static TranslationResult ErrorReslt(string error, string sourceLang = null, string destLang = null, IEnumerable<WordTranslation> translations = null)
        {
            return new TranslationResult(false, sourceLang, destLang, translations, error);
        }
    }
}
