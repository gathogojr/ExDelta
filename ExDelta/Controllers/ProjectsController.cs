using ExDelta.Data;
using ExDelta.Models;
using Microsoft.AspNet.OData;
using System.Linq;

namespace ExDelta.Controllers
{
    public class ProjectsController : ODataController
    {
        private ExDeltaDbContext _db;

        public ProjectsController(ExDeltaDbContext db)
        {
            _db = db;
        }

        [EnableQuery]
        public IQueryable<Project> Get()
        {
            return _db.Projects;
        }

        [EnableQuery]
        public SingleResult<Project> Get([FromODataUri] int key)
        {
            return SingleResult.Create(_db.Projects.Where(d => d.Id.Equals(key)));
        }

        [EnableQuery]
        public IQueryable<Project> KeyProjects()
        {
            return _db.Projects;
        }

        [EnableQuery]
        public IQueryable<Milestone> KeyMilestones()
        {
            return _db.Milestones;
        }
    }
}
