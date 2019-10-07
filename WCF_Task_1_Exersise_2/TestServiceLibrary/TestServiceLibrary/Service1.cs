using System.Linq;
using System.Collections.Generic;

namespace TestServiceLibrary
{
    public class Service1 : IService1
    {
        public readonly IList<Openings> _lstOpenings = new List<Openings>();

        public Service1()
        {
            this._lstOpenings.Add(new Openings() { JobTitle = "AEM Developer", JobRole = "Developer" }) ;
            this._lstOpenings.Add(new Openings() { JobTitle = "Scintific Software Applicatin Development", JobRole = "Sr. Software Engineer" });
            this._lstOpenings.Add(new Openings() { JobTitle = "WPF Developer", JobRole = "Software Engineer" });
            this._lstOpenings.Add(new Openings() { JobTitle = "SQL Developer", JobRole = "Sr. Software Engineer" });
            this._lstOpenings.Add(new Openings() { JobTitle = "Backend Developer", JobRole = "Sr. Software Engineer" });
            this._lstOpenings.Add(new Openings() { JobTitle = "Software Analyst", JobRole = "Analyst" });
            this._lstOpenings.Add(new Openings() { JobTitle = "SQL Developer", JobRole = "Software Engineer" });
        }

        public IList<Openings> OpeningJobs()
        {
            return this._lstOpenings;
        }

        public IList<Openings> OpeningJobsByRole(string role)
        {
            return this._lstOpenings.Where(q => q.JobRole.Equals(role)).ToList();
        } 
    }
}
