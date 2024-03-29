namespace Gregslist_DotNet.Controllers;


[ApiController]
[Route("api/[controller]")]
public class HousesController : ControllerBase {
    private readonly HousesService _housesService;

    public HousesController(HousesService housesService) {
        _housesService = HousesService;
    }

    [HttpGet]
    public ActionResult<List<House>> GetHouses()
    {
        try
        {
            List<House> houses = _housesService.getHouses();
        }
        catch (Exception exception)
        {
            
            return BadRequest(exception.Message)
        }
    }

}