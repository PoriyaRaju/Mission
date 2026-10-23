using Microsoft.EntityFrameworkCore;
using Mission.Entities;
using Mission.Entities.ViewModels.MissionAnalysisList;
using Mission.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Repositories.Repository
{
  public class MissionAnalysisRepository(MissionDbContext dbContext) : IMissionAnalysisRepository
  {
    private readonly MissionDbContext _dbContext = dbContext;
    Random rnd = new Random();
    public async Task<List<MissionAnalysisListModel>> GetMissionAnalysisList()
    {
      return await _dbContext.Missions
          .Select(m => new MissionAnalysisListModel()
          {
            missionName = m.MissionTitle,
            status = (m.EndDate != null && m.EndDate >= DateTime.UtcNow) ? "Active" : "In-Active",
            seats = m.TotalSeats,
          

            // Generates number in range [3, 6) => 3, 4, or 5
            rating = rnd.Next(3, 6),
          })
          .ToListAsync();
    }
  }
}
