using Microsoft.AspNetCore.Mvc;
using Mission.Entities.ViewModels;
using Mission.Services.IService;
using Mission.Services.Service;

namespace Mission.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MissionAnalysisController(IMissionAnalysisServices missionAnalysisService) : ControllerBase
  {
    private readonly IMissionAnalysisServices _missionAnalysisService = missionAnalysisService;
    [HttpGet]
    [Route("GetMissionAnalysisList")]
    public async Task<IActionResult> GetMissionAnalysisList()
    {
      try
      {
        var res = await _missionAnalysisService.GetMissionAnalysisList();
        return Ok(new ResponseResult() { Data = res, Result = ResponseStatus.Success, Message = "" });
      }
      catch(Exception e)
      {
        return BadRequest(new ResponseResult() { Data = null, Result = ResponseStatus.Error, Message = "Failed to get mission theme" });
      }
    }

  }
}
