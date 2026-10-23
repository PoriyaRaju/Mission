using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities.ViewModels.MissionAnalysisList
{
  public class MissionAnalysisListModel
  {
    public string missionName { get; set; }
    public string status { get; set; }
    public int seats { get; set; }
    public int rating { get; set; }
  }
}
