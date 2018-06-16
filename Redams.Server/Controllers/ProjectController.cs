using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redams.Server.Controllers
{
    [Produces("application/json")]
    [Route("api/Project")]
    public class ProjectController : Controller
    {



        [HttpGet]
        public IList<Common.Model.DAL.Project> Get()
        {

            var projects = new List<Common.Model.DAL.Project>();
            foreach (var p in this.mainDbRealmDatabaseService.Realm.All<Common.Model.Project>())
            {
                projects.Add(new Common.Model.DAL.Project { ProjectName = p.ProjectName, ID = p.ID, ShortName = p.ShortName });
            }
            return projects;


        }





        [HttpGet("{ProjectID}")]
        public Common.Model.DAL.Project Get(string ProjectID)
        {


            var p = this.mainDbRealmDatabaseService.Realm.All<Common.Model.Project>().Where(pr=>pr.ID == ProjectID).First();

            
            return   new Common.Model.DAL.Project { ProjectName = p.ProjectName, ID = p.ID, ShortName = p.ShortName };
           


        }

        Models.Realm.IMainDbRealmDatabaseService mainDbRealmDatabaseService;
        public ProjectController(Models.Realm.IMainDbRealmDatabaseService _mainDbRealmDatabaseService)
        {
            this.mainDbRealmDatabaseService = _mainDbRealmDatabaseService;
        }
        [HttpPost]
        public Common.Model.DAL.Project Post([FromBody] Common.Model.DAL.Project project)
        {
            this.mainDbRealmDatabaseService.Realm.Add(new Common.Model.Project { ID = project.ID, ProjectName = project.ProjectName, ShortName = project.ShortName });

            this.mainDbRealmDatabaseService.Commit();
            return project;
        }
    }
}
