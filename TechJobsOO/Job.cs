using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency coreCompetency) :this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = coreCompetency;
        }


        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string jobData = "\n";

            for (int i=0; i<6; i++)
            {
                if(i==0)
                {
                    if(!String.IsNullOrEmpty(Id.ToString()))
                    {
                        jobData = jobData + "ID: " + Id.ToString() + "\n";
                    }
                    else
                    {
                        jobData = jobData + "ID: Data not available" + "\n";
                    }
                }
                else if (i==1)
                {
                    if (!String.IsNullOrEmpty(Name))
                    {
                        jobData = jobData + "Name: " + Name + "\n";
                    }
                    else
                    {
                        jobData = jobData + "Name: Data not available" + "\n";
                    }
                }
                else if (i==2)
                {
                    if (!String.IsNullOrEmpty(EmployerName.ToString()))
                    {
                        jobData = jobData + "Employer: " + EmployerName.ToString() + "\n";
                    }
                    else
                    {
                        jobData = jobData + "Employer: Data not available" + "\n";
                    }
                }
                else if (i==3)
                {
                    if (!String.IsNullOrEmpty(EmployerLocation.ToString()))
                    {
                        jobData = jobData + "Location: " + EmployerLocation.ToString() + "\n";
                    }
                    else
                    {
                        jobData = jobData + "Location: Data not available" + "\n";
                    }
                }
                else if (i==4)
                {
                    if (!String.IsNullOrEmpty(JobType.ToString()))
                    {
                        jobData = jobData + "Position Type: " + JobType.ToString() + "\n";
                    }
                    else
                    {
                        jobData = jobData + "Position Type: Data not available" + "\n";
                    }
                }
                else if (i==5)
                {
                    if (!String.IsNullOrEmpty(JobCoreCompetency.ToString()))
                    {
                        jobData = jobData + "Core Competency: " + JobCoreCompetency.ToString() + "\n";
                    }
                    else
                    {
                        jobData = jobData + "Core Competency: Data not available" + "\n";
                    }
                }
            }

            return jobData;
        }
    }
}
