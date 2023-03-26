using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
	public class IndexModel : PageModel
	{
        // Create a DataAccessController object
        DataAccessController dac = new DataAccessController();

        // Create a collection for holding CoursesAndModules object
        public List<CoursesAndModules> CoursesAndModules;

        public void OnGet()
        {
            // Retrieve the data using the DataAccessController object and populate the CoursesAndModules object
            CoursesAndModules = dac.GetAllCoursesAndModules().ToList();
        }
    }
}