using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.Json.Serialization;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class Cadastro : Controller
    {

        // GET: Cadastro
        public ActionResult Index()
        {

            return View();
        }

        // GET: Cadastro/Details/5
        public ActionResult Details(string ID_REGISTRO)
        {
            HttpClient http = new HttpClient();
            var response = http.GetAsync("https://localhost:7245/api/Cadastro/{"+ ID_REGISTRO+"}").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var jsonobjet = JsonConvert.DeserializeObject<TB_CADASTRO>(json.Replace("\\", "").Replace("[", "").Replace("]", ""));

            if (jsonobjet != null)
            {
                return View(jsonobjet);
            }
            return View();
        }

        // GET: Cadastro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cadastro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TB_CADASTRO model)
        {
            try
            {
                HttpClient http = new HttpClient();
                var json = JsonConvert.SerializeObject(model);

                var payload = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = http.PostAsync("https://localhost:7245/api/Cadastro", payload).Result.Content.ReadAsStringAsync().Result;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cadastro/Edit/5
        public ActionResult Edit(string id)
        {
            HttpClient http = new HttpClient();
            var response = http.GetAsync("https://localhost:7245/api/Cadastro/{" + id + "}").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var jsonobjet = JsonConvert.DeserializeObject<TB_CADASTRO>(json.Replace("\\", "").Replace("[", "").Replace("]", ""));

            if (jsonobjet != null)
            {
                return View(jsonobjet);
            }
            return View();
        }

        // POST: Cadastro/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TB_CADASTRO model)
        {
            try
            {
                HttpClient http = new HttpClient();
                var json = JsonConvert.SerializeObject(model);

                var payload = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = http.PostAsync("https://localhost:7245/api/Cadastro", payload).Result.Content.ReadAsStringAsync().Result;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cadastro/Delete/5
        public ActionResult Delete(string ID_REGISTRO)
        {
            HttpClient http = new HttpClient();
            var response = http.GetAsync("https://localhost:7245/api/Cadastro/{" + ID_REGISTRO + "}").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var jsonobjet = JsonConvert.DeserializeObject<TB_CADASTRO>(json.Replace("\\", "").Replace("[", "").Replace("]", ""));

            if (jsonobjet != null)
            {
                return View(jsonobjet);
            }
            return View();
        }

        // POST: Cadastro/Delete/5
        [HttpPost]
        public ActionResult Delete(TB_CADASTRO model)
        {
            try
            {
                HttpClient http = new HttpClient();
                var response = http.DeleteAsync("https://localhost:7245/api/Cadastro/{" + model.ID_REGISTRO + "}").Result;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
