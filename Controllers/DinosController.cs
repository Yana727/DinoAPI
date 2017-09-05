using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DinoAPI.Models; //bc we created the folder "Models"

namespace DinoAPI.Controllers
{
    [Route("api/Dinos")]
    public class DinosController : Controller
    {
        // GET api/Dinos 
        [HttpGet]
        public List<DinoModel> Get() //this will get all of the Dinos 
        {     
            var Dino = new DinoModel(); 
            //list of dinoModel is now called Dinosaurs
            List<DinoModel>Dinosaurs = Dino.DinoListGetter(); 
            return Dinosaurs;
        }

       [HttpGet("{id}")] //rout to get the id
       public DinoModel Get(int id)
       {
           var Dino = new DinoModel();
           List<DinoModel>DinoID = Dino.DinoListGetter(); 
           return DinoID[id-1]; 
       }
        
        // GET api/values/5
    
        public string Post(int name)
        {
            return "value";
        }

// Adding this here to see how it works

        [HttpGet("{id}/Dinos/{Dinos}")]
        public void Myget( int id, string name)
        {
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
