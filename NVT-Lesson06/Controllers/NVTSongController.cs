using NVT_Lesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NVT_Lesson06.Controllers
{
    public class NVTSongController : Controller
    {
        private static List<NVTSong> nvtSongs = new List<NVTSong>()
        {
            new NVTSong{Id=100,nvtTitle="Nguyễn Văn Thạo",nvtAuthor="K22CNT10",nvtArtist="Thạo",nvtYearRelease=1900},
            new NVTSong{Id=101,nvtTitle="Love Song",nvtAuthor="K22CNT10",nvtArtist="Thạo",nvtYearRelease=2020},
        };
        // GET: NVT
        public ActionResult Index()
        {
            return View(nvtSongs);
        }
        public ActionResult nvtCreate()
        {
            var nvtSong = new NVTSong();
            return View(nvtSong);
        }
        public ActionResult NVTCreate(NVTSong nvtSong)
        {
            if (!ModelState.IsValid)
            {
                return View(nvtSong);
            }

            nvtSongs.Add(nvtSong);
            return RedirectToAction("Index");

        }
    }
}