﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly OnlinePharmacy.Data.OnlinePharmacyContext _context;

        public IndexModel(OnlinePharmacy.Data.OnlinePharmacyContext context)
        {
            _context = context;
        }

        public IList<Medicine> Medicine { get;set; }

        public async Task OnGetAsync()
        {
            Medicine = await _context.Medicine.ToListAsync();
        }
    }
}
