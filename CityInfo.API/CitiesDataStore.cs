using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }


  
        public static CitiesDataStore Current { get; } = new CitiesDataStore(); //Không hiểu rõ


        public CitiesDataStore() {
            Cities = new List<CityDto>()
            {
                new CityDto() {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one withh that big park",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the UnitedStates",

                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Emprire State Buliding",
                            Description = "A 102-story skycraper",
                        },
                    }
                    
                },
                new CityDto() {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one that big tower",
                    PointOfInterests= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Eiffel Tower",
                            Description = "A wrought iron lattice tower",

                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name ="The Louvere",
                            Description = "The world,s largest museum",
                        }
                    }
                },
                

            };
                
        }
    }
}
