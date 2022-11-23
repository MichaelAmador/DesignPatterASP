using DesignPattern.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Generator;

namespace DesignPatternsASP.Controllers
{
    public class GeneratorFileController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private GeneratorConcreteBuilder _generatorConcreteBuilder;

        public GeneratorFileController(IUnitOfWork unitOfWork, GeneratorConcreteBuilder generatorConcreteBuilder)
        {
            _unitOfWork = unitOfWork;
            _generatorConcreteBuilder = generatorConcreteBuilder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int optionFile)
        {
            try
            {
                var beers = _unitOfWork.Beers.Get();
                List<string> content = beers.Select(d => d.Name).ToList();
                string path = "file" + DateTime.Now.Ticks + new Random().Next(100) + ".txt";
                var generadorDirector = new GeneratorDirector(_generatorConcreteBuilder);

                if (optionFile == 1) generadorDirector.CreateSimpleJsonGenerator(content, path);
                else generadorDirector.CreateSimplePipeGenerator(content, path);

                var generator = _generatorConcreteBuilder.GetGenerator();
                generator.Save();

                return Json("File created");
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}
