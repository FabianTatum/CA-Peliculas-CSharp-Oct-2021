using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CrAgPeliculas.App.Shared.Entity; 
using CrAgPeliculas.App.Server.Helpers;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CrAgPeliculas.App.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly AppContext context;
        private readonly IFileStore filestore;
        private readonly string container = "StaffProfile";

        public StaffController(AppContext context, IFileStore filestore)
        {
            this.filestore = filestore;
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Staff staff)
        { 
            var profile = Convert.FromBase64String(staff.ProfileImage);
            staff.ProfileImage = await filestore.SaveFile(profile, ".jpg", container);

            context.Add(staff);
            await context.SaveChangesAsync();
            return staff.Id;
        }
        [HttpGet]
        public async Task<ActionResult<List<Staff>>> Get()
        {
            var staffs = await context.StaffTB.ToListAsync();
            return staffs;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Staff>> Get(int id)
        {
            var staff = await context.StaffTB.Where(m => m.Id == id).FirstOrDefaultAsync();

            if(staff == null) 
            {
                return NotFound();
            }
            else
            {
                return new Staff()
                {
                    Name = staff.Name,
                    LastName = staff.LastName,
                    DateOfBirth = staff.DateOfBirth,
                    Gender = staff.Gender,
                    Role = staff.Role,
                    CityOfBirth = staff.CityOfBirth,
                    ProfileImage = staff.ProfileImage,
                    KnowCredits = staff.KnowCredits,
                    Biography = staff.Biography
                };
            }
        }
    }
}