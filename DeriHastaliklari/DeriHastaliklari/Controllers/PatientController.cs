using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DeriHastaliklari.Models;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace DeriHastalikleri.Controllers
{
    public class PatientController : Controller
    {

        Context c = new Context();
       /* private readonly Context _context;

        public PatientController(//Context context
            )
        {
            //PatientController üzerine gelip Generate Constructor yap otomatik gelyor
           // _context = context;
        }*/
        public IActionResult PatientLogin()
        {

            return View();
        }

       
        public IActionResult PatientRegister() { return View(); }   
        public async Task<IActionResult> PatientRegisterSave(Patient p)
        {
            await c.Patients.AddAsync(p);
            await c.SaveChangesAsync();
            return RedirectToAction("PatientLogin", "Patient");

        }

        [HttpGet]
        public IActionResult DoctorLogin()
        {
            return View();
        }

        //alt+shift+f10
        //ctrl+k+c
        //ctrl+k+u
        public async Task<IActionResult> DoctorLogin(Doctor request)
        {
            var bilgiler = c.Doctors.FirstOrDefault(x => x.Username == request.Username && x.Password == request.Password);
            if (bilgiler != null)
            {
                //kullanıcı bilgilerini tutar 
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, request.Username)
                };

                var useridentity = new ClaimsIdentity(claims, "Patient");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "DataGoruntuleme");

            }

            return View();
        }

    }
}
