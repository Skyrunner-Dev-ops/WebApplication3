using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class QuizController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetQuestion(int id)
        {
            if (id > QuestionData.Questions.Count)
            {
                return Json(new { done = true }, JsonRequestBehavior.AllowGet);
            }

            var question = QuestionData.Questions.FirstOrDefault(q => q.Id == id);
            return Json(new
            {
                id = question.Id,
                text = question.Text,
                options = question.Options.Select(o => new
                {
                    text = o.Text,
                    traits = string.Join(",", o.Traits)
                })
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SubmitAnswer(int questionId, string selectedTraits)
        {
            var traits = selectedTraits.Split(',').Select(t => t.Trim()).ToList();
            ArrayList responses = Session["Responses"] as ArrayList ?? new ArrayList();

            foreach (var trait in traits)
                responses.Add(trait);

            Session["Responses"] = responses;

            if (questionId >= QuestionData.Questions.Count)
            {
                Dictionary<string, int> traitCounts = new Dictionary<string, int>();
                foreach (string trait in responses)
                {
                    if (traitCounts.ContainsKey(trait)) traitCounts[trait]++;
                    else traitCounts[trait] = 1;
                }

                string bestAnimal = "";
                int bestMatch = 0;

                foreach (var animal in QuestionData.AnimalTraits)
                {
                    int score = animal.Value.Sum(trait => traitCounts.ContainsKey(trait) ? traitCounts[trait] : 0);
                    if (score > bestMatch)
                    {
                        bestMatch = score;
                        bestAnimal = animal.Key;
                    }
                }

                Session.Remove("Responses");

                return Json(new { done = true, animal = bestAnimal });
            }

            return Json(new { done = false, nextId = questionId + 1 });
        }
    }
}
