using StudentManagement.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.API.Tests.Services
{
    public class StudentServiceTests
    {
        [Fact]
        public void GetAll_shouldReturnAllStudents()
        {
            var service = new StudentService();
            var result = service.GetAll();
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal(2, result.Count);
        }
    }
}
