using Microsoft.Data.SqlClient;
using AllAboutDogs.Shared;
using System;
using System.Globalization;

namespace AllAboutDogs.Server.Functions
{
    public class DatabaseConnection
    {
        private SqlConnection createConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "dogskye.database.windows.net";
            builder.UserID = "skyerenda";
            builder.Password = "Angelicbeauty12";
            builder.InitialCatalog = "dogskye";

            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            return connection;

        }
        public List<Dog> fetchDogs()
        {
            List<Dog> allDogs = new List<Dog> { };
            SqlConnection connection = createConnection();
            try
            {
                String sql = "SELECT * FROM dbo.DogInformation ";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string breedName = reader.GetString(1);
                            string bredFor = reader.GetString(2);
                            string breedGroup =reader.GetString(3);
                            string tempermant = reader.GetString(4);
                            string origin = reader.GetString(5);
                            string imageURL = reader.GetString(6);
                            decimal maxWeight = reader.GetDecimal(7);
                            decimal minWeight = reader.GetDecimal(8);
                            decimal maxHeight = reader.GetDecimal(9);
                            decimal minHeight = reader.GetDecimal(10);
                            decimal maxLife = reader.GetDecimal(11);
                            decimal minLife = reader.GetDecimal(12);

                            Dog newDog = new(id, breedName, bredFor, breedGroup, tempermant, origin, imageURL, maxWeight, minWeight, maxHeight, minHeight, maxLife, minLife);
                            allDogs.Add(newDog);
                        }
                    }
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return allDogs;
        }

        public List<BreedName> fetchListOfBreeds()
        {
            List<BreedName> breedNames = new();
            SqlConnection connection = createConnection();
            try
            {
                String sql = "select breedName from  [dbo].[DogInformation]";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string breedName = reader.GetString(0);

                            BreedName name = new BreedName(breedName);
                            breedNames.Add(name);
                        }
                    }
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return breedNames;
        }
        public Dog fetchDog(string name)
        {
            Dog doggy = new();
            SqlConnection connection = createConnection();
            try
            {
                String sql = $"select * from  [dbo].[DogInformation] INNER JOIN [dbo].[images] ON ([dbo].[DogInformation].reference_image_id = [dbo].[images].id) where breedName = '{name}';";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doggy.id = reader.GetInt32(0);
                            doggy.breedName = reader.GetString(1);
                            doggy.bredFor = reader.GetString(2);
                            doggy.breedGroup = reader.GetString(3);
                            doggy.temperment = reader.GetString(4);
                            doggy.origin = reader.GetString(5);
                            doggy.imageURL = reader.GetString(16);
                            doggy.MaxWeight = reader.GetDecimal(7);
                            doggy.MinWeight = reader.GetDecimal(8);
                            doggy.MaxHeight = reader.GetDecimal(9);
                            doggy.MinHeight = reader.GetDecimal(10);
                            doggy.MaxLife = reader.GetDecimal(11);
                            doggy.MinLife = reader.GetDecimal(12);
                            
                        }
                    }
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return doggy;
        }
    }
    
}
