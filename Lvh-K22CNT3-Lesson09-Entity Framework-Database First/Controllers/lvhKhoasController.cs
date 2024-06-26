using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lvh_K22CNT3_Lesson09_Entity_Framework_Database_First.Models;

namespace Lvh_K22CNT3_Lesson09_Entity_Framework_Database_First.Controllers
{
    public class lvhKhoasController : Controller
    {
        private LvhK22CNT3Lesson09DbEntities db = new LvhK22CNT3Lesson09DbEntities();

        // GET: lvhKhoas
        public async Task<ActionResult> Index()
        {
            return View(await db.lvhKhoas.ToListAsync());
        }

        // GET: lvhKhoas/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lvhKhoa lvhKhoa = await db.lvhKhoas.FindAsync(id);
            if (lvhKhoa == null)
            {
                return HttpNotFound();
            }
            return View(lvhKhoa);
        }

        // GET: lvhKhoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: lvhKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LvhMaKH,LvhTenKH")] lvhKhoa lvhKhoa)
        {
            if (ModelState.IsValid)
            {
                db.lvhKhoas.Add(lvhKhoa);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(lvhKhoa);
        }

        // GET: lvhKhoas/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lvhKhoa lvhKhoa = await db.lvhKhoas.FindAsync(id);
            if (lvhKhoa == null)
            {
                return HttpNotFound();
            }
            return View(lvhKhoa);
        }

        // POST: lvhKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LvhMaKH,LvhTenKH")] lvhKhoa lvhKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lvhKhoa).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(lvhKhoa);
        }

        // GET: lvhKhoas/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lvhKhoa lvhKhoa = await db.lvhKhoas.FindAsync(id);
            if (lvhKhoa == null)
            {
                return HttpNotFound();
            }
            return View(lvhKhoa);
        }

        // POST: lvhKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            lvhKhoa lvhKhoa = await db.lvhKhoas.FindAsync(id);
            db.lvhKhoas.Remove(lvhKhoa);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
