using EasyCashProjectDtoLayer.Dtos.AppUserDtos;
using EasyCashProjectEntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace EasyCashProjectPresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto user)
        {
            if (ModelState.IsValid)
            {
                Random random = new Random();
                int code;
                code = random.Next(100000, 1000000);

				AppUser appUser = new AppUser()
                {
                    UserName = user.UserName,
                    Name = user.Name,
                    Surname = user.Surname,
                    Email = user.Email,
                    City = "null",
                    District= "null",
                    ImageUrl = "null",
                    ConfirmCode = code

				};
                var result = await _userManager.CreateAsync(appUser, user.Password);

                if (result.Succeeded)
                {
                    MimeMessage mimeMessage = new MimeMessage();
                    MailboxAddress mailboxAddressFrom = new MailboxAddress("Easy Cash Admin", "seherselin9@gmail.com");
                    MailboxAddress mailboxAddressTo = new MailboxAddress("User", appUser.Email);

                    mimeMessage.From.Add(mailboxAddressFrom);
                    mimeMessage.To.Add(mailboxAddressTo);

                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = "Kayıt işlemini tamamlamak için onay kodunuz:" + code;
                    mimeMessage.Body = bodyBuilder.ToMessageBody();

                    mimeMessage.Subject = "Easy Cash Onay Kodu";
                    SmtpClient client = new SmtpClient();
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("seherselin9@gmail.com", "ksdwzgkmmvmkbqlg");
                    client.Send(mimeMessage);
                    client.Disconnect(true);

                    TempData["Mail"] = user.Email;

                    return RedirectToAction("Index", "ConfirmMail");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View();
        }
    }
}
