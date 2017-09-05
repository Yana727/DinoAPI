using System;
using System.Collections.Generic;

namespace DinoAPI.Models
{
    public class DinoModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public string size { get; set; }
        public string weight { get; set; }

        public string habitat { get; set; }

        public DinoModel()
        {
        }
        public List<DinoModel> DinoListGetter()
        {
            var DinoList = new List<DinoModel>();
            var Alamosaurus = new DinoModel
            {
                id = 1,
                name = "Alamosaurus",
                size = "98 ft",
                weight = "73 tonnes",
                habitat =
              "Skeletal elements of Alamosaurus are among the most common Late Cretaceous dinosaur fossils found in the United States Southwest and are now used to define the fauna of that time and place, known as the Alamosaurus fauna."
            };
            var Albertaceratops = new DinoModel
            {
                id = 2,
                name = "Albertaceratops",
                size = "19 ft",
                weight = "7,700 lb",
                habitat = "North America"
            };
            var Anchiceratops = new DinoModel
            {
                id = 3,
                name = "Anchiceratops",
                size = "16.4 ft",
                weight = "1.2 tonnes",
                habitat =
               "Most Anchiceratops fossils have been discovered in the Horseshoe Canyon Formation of Alberta, which belongs to the later part of the Campanian stage of the Late Cretaceous Period (Anchiceratops remains are known from the lower part of the formation, and range in age between 72.5-71 million years ago)"
            };
            var Ankylosaurus = new DinoModel
            {
                id = 4,
                name = "Ankylosaurus",
                size = "20.5 feet",
                weight = "13,000 lb",
                habitat = "Canada"
            }; 
  var Barney = new DinoModel
  {
      id = 5,
      name = "Barney",

      size = "6 ft",
      weight = "150 lb",
      habitat = "Hollywood, CA"
  };
            DinoList.Add(Alamosaurus);
            DinoList.Add(Albertaceratops);
            DinoList.Add(Anchiceratops);
            DinoList.Add(Ankylosaurus);
            DinoList.Add(Barney);
            return DinoList;
        }
    }
}

