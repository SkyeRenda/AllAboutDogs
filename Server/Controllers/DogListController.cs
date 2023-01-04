using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AllAboutDogs.Shared;
using AllAboutDogs.Server.Functions;

namespace AllAboutDogs.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogListController : ControllerBase
    {
        [HttpGet]

        public List<Dog> Get()
        {
            DatabaseConnection connect = new DatabaseConnection();
            List<Dog> dogList =  connect.fetchDogs();
            return dogList;
        }

        [HttpGet("FetchBreedList")]

        public List<BreedName> FetchBreedList() {
            DatabaseConnection connect = new DatabaseConnection();
            List<BreedName> breedList = connect.fetchListOfBreeds();
            return breedList;
        }
        [HttpGet("SingleDog")]
        public Dog FetchDog(string breedName)
        {
            DatabaseConnection connect = new DatabaseConnection();
            Dog dog = connect.fetchDog(breedName);
            return dog;
        }
    }
}
