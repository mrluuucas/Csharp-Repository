ublic class CustomerController : Controller
{
  private UnitOfWork unitOfWork = new UnitOfWork();

  // GET: /Customer/
  public ViewResult Index()
  {
     var Customers = unitOfWork.CustomerRepository.Get();
     return View(Customers.ToList());
  }

  // GET: /Customer/Details/5
  public ViewResult Details(int id)
  {
     Customer Customer = unitOfWork.CustomerRepository.GetByID(id);
     return View(Customer);
  }

  // GET: /Customer/Create
  public ActionResult Create()
  {
     return View();
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public ActionResult Create(Customer Customer)
  {
     try
     {
        if (ModelState.IsValid)
        {
           unitOfWork.CustomerRepository.Insert(Customer);
           unitOfWork.Save();
           return RedirectToAction("Index");
        }
     }
     catch (DataException)
     {
        ModelState.AddModelError("", "Unable to save changes.");
     }
     return View(Customer);
  }

  public ActionResult Edit(int id)
  {
     Customer Customer = unitOfWork.CustomerRepository.GetByID(id);     
     return View(Customer);
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public ActionResult Edit(       
     Customer Customer)
  {
     try
     {
        if (ModelState.IsValid)
        {
           unitOfWork.CustomerRepository.Update(Customer);
           unitOfWork.Save();
           return RedirectToAction("Index");
        }
     }
     catch (DataException)
     {
        ModelState.AddModelError("", "Unable to save changes.");
     }
     return View(Customer);
  }

  // GET: /Customer/Delete/5
  public ActionResult Delete(int id)
  {
     Customer Customer = unitOfWork.CustomerRepository.GetByID(id);
     return View(Customer);
  }

  // POST: /Customer/Delete/5
  [HttpPost, ActionName("Delete")]
  [ValidateAntiForgeryToken]
  public ActionResult DeleteConfirmed(int id)
  {
     Customer Customer = unitOfWork.CustomerRepository.GetByID(id);
     unitOfWork.CustomerRepository.Delete(id);
     unitOfWork.Save();
     return RedirectToAction("Index");
  }

  protected override void Dispose(bool disposing)
  {
     unitOfWork.Dispose();
     base.Dispose(disposing);
  }
}
