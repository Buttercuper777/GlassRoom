using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Domain;
using System.Net;
using System.Net.Mail;

namespace GlassRoomWebApp.Controllers
{
    public class SendMailController : Controller
    {
        private readonly DataManager dataManager;
    }
}
