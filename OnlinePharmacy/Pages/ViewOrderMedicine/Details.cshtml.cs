using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Data;
using OnlinePharmacy.Models;

namespace OnlinePharmacy.Pages.OrderViewMedicine
{
    public class DetailsModel : PageModel
    {
        private readonly OnlinePharmacy.Data.OnlinePharmacyContext _context;

        public DetailsModel(OnlinePharmacy.Data.OnlinePharmacyContext context)
        {
            _context = context;
        }

        public OrderMedicine OrderMedicine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderMedicine = await _context.OrderMedicine.FirstOrDefaultAsync(m => m.id == id);

            if (OrderMedicine == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
