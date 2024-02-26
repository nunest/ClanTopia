using Dto = ClanTopia.Dto;

namespace Clans.Create
{
    public class Request : Dto.Clan
    {
    
    }

    internal sealed class Validator : Validator<Request>
    {
        public Validator()
        {

        }
    }

  public class Response
    {
        public string Message { get; set; } = "";
    }
}
