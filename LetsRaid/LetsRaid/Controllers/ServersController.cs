using LetsRaid.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LetsRaid.Controllers
{
    public class ServersController : Controller
    {
        LetsraidContext _context;
        public ServersController()
        {
            _context = new LetsraidContext();
        }
        // GET: Servers
        public ActionResult Index()
        {
            var servers = _context.Servers.ToList();
            return View(servers);
        }

        public ActionResult Details(int? id)
        {
            var server = _context.Servers.Find(id);
            return View(server);
        }

        [Route("Servers/{serverId}/Guilds/{guildId}/Characters")]
        public ActionResult GetCharacters(int? serverId, int? guildId)
        {
            //Call my service with my serverId and GuildId
            var server = _context.Servers.Find(serverId);
            var guild = _context.Guilds.Find(guildId);
            //Get data from Blizzard API using things about server/guild.
            //Build ViewModel.
            //Return to view.
            return View();
        }
    }
}