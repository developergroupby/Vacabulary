using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Vacabulary.Models;

namespace Vacabulary.Controllers
{
    public class DictionaryController : ApiController
    {
        public TranslationResult PostFile()
        {
            var httpRequest = HttpContext.Current.Request;

            string fromLang = HttpContext.Current.Request.Params["fromLang"],
                   toLange = HttpContext.Current.Request.Params["toLang"];

            if (httpRequest.Files.Count < 1)
            {
                return TranslationResult.ErrorReslt("File is required");
            }

            if (httpRequest.Files.Count > 1)
            {
                return TranslationResult.ErrorReslt("Too many files. Only one file is required");
            }

            foreach (string file in httpRequest.Files)
            {
                var postedFile = httpRequest.Files[file];

                if (!Subtitles.IsSupported(postedFile.FileName))
                {
                    return TranslationResult.ErrorReslt("Invalid file type");
                }

                return TranslationResult.SuccessResult("EN", "RU", Temp(postedFile.InputStream));
                //var filePath = HttpContext.Current.Server.MapPath("~/" + postedFile.FileName);
                //postedFile.SaveAs(filePath);
                // NOTE: To store in memory use postedFile.InputStream
            }
            
            return TranslationResult.ErrorReslt("Unknown error");
        }

        public string Get()
        {
            return "Hello World";
        }

        private WordTranslation[] Temp(Stream fileStream)
        {
            var textReader = new StreamReader(fileStream);
            return
                textReader.ReadToEnd()
                    .Split(' ')
                    .Select(s => new WordTranslation(s, "Translation is not imlemented"))
                    .ToArray();
        }
    }
}