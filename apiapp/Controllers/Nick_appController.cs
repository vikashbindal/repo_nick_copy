using System;
using System.Diagnostics.Contracts;
using System.Web.Http;

namespace Nick Innovation.Nick on Time.Controllers
{
	public class Nick_appController : ApiController
	{
		[HttpGet]
		[Route("api/Nick_app")]
		public String Get()
		{
			Contract.Ensures(Contract.Result<String>() != null);

			return "Hello API App!";
		}
	}
}
