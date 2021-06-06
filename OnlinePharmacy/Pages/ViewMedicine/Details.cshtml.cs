using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Data;
using OnlinePharmacy.Models;

namespace OnlinePharmacy.Pages.ViewMedicine
{
    public class DetailsModel : PageModel
    {
        private readonly OnlinePharmacy.Data.OnlinePharmacyContext _context;

        public DetailsModel(OnlinePharmacy.Data.OnlinePharmacyContext context)
        {
            _context = context;
        }

        public Medicine Medicine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medicine = await _context.Medicine.FirstOrDefaultAsync(m => m.Id == id);

            if (Medicine == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
