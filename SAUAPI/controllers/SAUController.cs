
using System.Web.Http;

namespace SAUAPI
{
    [Authorize]
    public class SAUController : ApiController
    {
        public IHttpActionResult get()
        {
            return Ok();
        }
    }
}
