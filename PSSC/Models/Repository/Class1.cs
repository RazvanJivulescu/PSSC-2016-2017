using System;
using System.Collections.Generic;
using Models.Student;

namespace Models.Repository
{
    // Repository for GradeReport aggregat root
    class GradeReportRepository : IRepository<Student.GradeReport>
    {
        public IEnumerable<GradeReport> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(GradeReport entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(GradeReport entity)
        {
            throw new NotImplementedException();
        }

        public GradeReport FindById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(GradeReport entity)
        {
            throw new NotImplementedException();
        }
    }
}