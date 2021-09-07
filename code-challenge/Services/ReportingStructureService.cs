using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using challenge.Models;
using Microsoft.Extensions.Logging;
using challenge.Repositories;

namespace challenge.Services
{
    public class ReportingStructureService : IReportingStructureService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ILogger<ReportingStructureService> _logger;

        public ReportingStructureService(ILogger<ReportingStructureService> logger, IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _logger = logger;
        }

        public ReportingStructure GetById(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                Employee employee = _employeeRepository.GetById(id);

                if (employee != null)
                {
                    int count = employee.DirectReports.Count();

                    return new ReportingStructure { Employee = employee, NumberOfReports = employee.DirectReports.Count() };
                }
            }

            return null;
        }
    }
}
