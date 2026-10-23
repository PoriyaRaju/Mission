using Mission.Entities.ViewModels.MissionAnalysisList;
using Mission.Repositories.IRepository;
using Mission.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.Service
{
  public class MissionAnalysisService(IMissionAnalysisRepository missionAnalysisRepository) : IMissionAnalysisServices
  {
    private readonly IMissionAnalysisRepository _missionAnalysisRepository = missionAnalysisRepository;


    public async Task<List<MissionAnalysisListModel>> GetMissionAnalysisList()
    {
      return await _missionAnalysisRepository.GetMissionAnalysisList();
    }
  }
}
