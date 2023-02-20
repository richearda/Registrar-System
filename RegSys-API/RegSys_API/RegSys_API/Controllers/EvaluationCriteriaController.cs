using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ISMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class EvaluationCriteriaController : Controller
    {

        private IEvaluationCriteriaService _evaluationCriteriaService;

        public EvaluationCriteriaController(IEvaluationCriteriaService evaluationCriteriaService)
        {
            _evaluationCriteriaService = evaluationCriteriaService;
        }
       
    }
}
