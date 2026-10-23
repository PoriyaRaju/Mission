using Mission.Entities.ViewModels.MissionAnalysisList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Repositories.IRepository
{
  public interface IMissionAnalysisRepository
  {
    Task<List<MissionAnalysisListModel>> GetMissionAnalysisList();
  }
}
