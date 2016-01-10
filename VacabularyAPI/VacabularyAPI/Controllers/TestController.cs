using System.Web.Http;
using Common.Contracts.Logging;
using DAL.Contracts.Repositories;
using DAL.Entities;

namespace VacabularyAPI.Controllers
{
    public class TestController : ApiController
    {
        public TestController(ILogger logger, IWordRepository wordRepository)
        {
            logger.Error("test");
            Word word = wordRepository.Get(1);
        }

        public string Get()
        {
            return "test";
        }
    }
}
