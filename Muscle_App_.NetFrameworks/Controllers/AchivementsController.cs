using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Muscle_App_.NetFrameworks.Models;

namespace Muscle_App_.NetFrameworks.Controllers
{
    //public class AchivementsController : BaseController
    //{
    //    // GET: Achivements
    //    [HttpGet, Route("/Achivements/Summary/Id")]
    //    public ActionResult Summary()
    //    {
    //        return View(db.Achivements.ToList());
    //    }

    //    // GET: Achivements/Details/5
    //    public ActionResult Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Achivement achivement = db.Achivements.Find(id);
    //        if (achivement == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(achivement);
    //    }

    //    // GET: Achivements/Create
    //    public ActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Achivements/Create
    //    // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
    //    // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Create([Bind(Include = "Id,UserId,MenuId,Assist,Times,Weight,Memo,Deleted,CreatedDatetime,UpdatedDatetime,DeletedDatetime")] Achivement achivement)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Achivements.Add(achivement);
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }

    //        return View(achivement);
    //    }

    //    // GET: Achivements/Edit/5
    //    public ActionResult Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Achivement achivement = db.Achivements.Find(id);
    //        if (achivement == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(achivement);
    //    }

    //    // POST: Achivements/Edit/5
    //    // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
    //    // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit([Bind(Include = "Id,UserId,MenuId,Assist,Times,Weight,Memo,Deleted,CreatedDatetime,UpdatedDatetime,DeletedDatetime")] Achivement achivement)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Entry(achivement).State = EntityState.Modified;
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }
    //        return View(achivement);
    //    }

    //    // GET: Achivements/Delete/5
    //    public ActionResult Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Achivement achivement = db.Achivements.Find(id);
    //        if (achivement == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(achivement);
    //    }

    //    // POST: Achivements/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult DeleteConfirmed(int id)
    //    {
    //        Achivement achivement = db.Achivements.Find(id);
    //        db.Achivements.Remove(achivement);
    //        db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }
    //}
}
