using System;
using BethanysPieShopHRM.Shared.Domain;

namespace FirstApp.Pages
{
	public partial class EmployeeOverview
	{
		public List<Employee>? Employees { get; set; } = default!;

        protected override void OnInitialized()
        {
            Employees = Models.MockDataService.Employees;
        }
    }
}

