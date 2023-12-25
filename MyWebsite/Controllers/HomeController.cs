using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;

namespace MyWebsite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult VBlog()
    {
        return View();
    }

    public IActionResult Projects()
    {
        return View();
    }

    public IActionResult Guests()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


    [HttpPost]
    public IActionResult Contact(string name, string surname, string subject, string email, string message)
    {
        // Burada e-posta gönderme işlemini gerçekleştir
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("gonderen_email@gmail.com");
            mail.To.Add("alici_email@gmail.com");
            mail.Subject = subject;
            mail.Body = $"Name: {name} {surname}\nEmail: {email}\n\n{message}";

            smtpServer.Port = 587;
            smtpServer.Credentials = new NetworkCredential("gonderen_email@gmail.com", "gonderen_email_sifresi");
            smtpServer.EnableSsl = true;

            smtpServer.Send(mail);

            ViewBag.MessageSent = "Your message has been sent successfully.";
        }
        catch (Exception ex)
        {
            ViewBag.MessageSent = "Error sending message: " + ex.Message;
        }

        return View("Contact");
    }










}

