using System.Diagnostics;
using BudgetWise.Models;
using Microsoft.AspNetCore.Mvc;

namespace BudgetWise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BudgetWiseDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, BudgetWiseDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Costs()
        {
            var allCosts=_dbContext.Costs.ToList();
            var totalCosts= allCosts.Sum(x => x.Value);
            ViewBag.Costs = totalCosts;
            return View(allCosts);
        }

        public IActionResult CreateEditCost(int? Id)
        {
            if (Id == null)
            {
                var costInDb = _dbContext.Costs.SingleOrDefault(cost => cost.Id == Id);
                return View(costInDb);
            }
            
            return View();
        }
        public IActionResult DeleteCost(int Id)
        {
            var costInDb = _dbContext.Costs.SingleOrDefault(cost => cost.Id == Id);
            _dbContext.Costs.Remove(costInDb);
            _dbContext.SaveChanges();
            return RedirectToAction("Costs");
        }
       
            public IActionResult CreateEditCostForm(Cost model)
        {
            if (_dbContext.Costs.Any(c => c.Id == model.Id))
            {
                _dbContext.Costs.Update(model);
            }
            else
            {
                _dbContext.Costs.Add(model);
            }
            _dbContext.SaveChanges();

            return RedirectToAction("Costs"); 
        }


    
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
