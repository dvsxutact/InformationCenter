using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Mileage { get; set; }
        public DateTime Purchase_Date { get; set; }
        public object Picture { get; set; }

        public async Task<bool> Add()
        {
            bool toReturn = false;

            const string query = "INSERT INTO [dbo].[Vehicle] ([Name], [Year], [Make], [Model], [Engine], [Mileage], [PurchaseDate]) VALUES(@name, @year, @make, @model, @engine, @mileage, @purchasedate)";

            using (SqlConnection myConnection = new SqlConnection(""))
            {
                await myConnection.OpenAsync();
                using (SqlCommand myCommand = new SqlCommand(query, myConnection))
                {
                    myCommand.Parameters.AddWithValue("@name", Name);
                    myCommand.Parameters.AddWithValue("@year", Year);
                    myCommand.Parameters.AddWithValue("@make", Make);
                    myCommand.Parameters.AddWithValue("@model", Model);
                    myCommand.Parameters.AddWithValue("@engine", Engine);
                    myCommand.Parameters.AddWithValue("@mileage", Mileage);
                    myCommand.Parameters.AddWithValue("@purchasedate", Purchase_Date);

                    var result = await myCommand.ExecuteNonQueryAsync();
                    if (result >= 1)
                        toReturn = true;
                }
            }

            return (toReturn);
        }

        public async Task<bool> Edit()
        {
            bool toReturn = false;

            const string query = "";

            using (SqlConnection myConnection = new SqlConnection(""))
            {
                await myConnection.OpenAsync();
                using (SqlCommand myCommand = new SqlCommand(query, myConnection))
                {
                    myCommand.Parameters.AddWithValue("@name", Name);
                    myCommand.Parameters.AddWithValue("@year", Year);
                    myCommand.Parameters.AddWithValue("@make", Make);
                    myCommand.Parameters.AddWithValue("@model", Model);
                    myCommand.Parameters.AddWithValue("@engine", Engine);
                    myCommand.Parameters.AddWithValue("@mileage", Mileage);
                    myCommand.Parameters.AddWithValue("@purchasedate", Purchase_Date);

                    var result = await myCommand.ExecuteNonQueryAsync();
                    if (result >= 1)
                        toReturn = true;
                }
            }

            return (toReturn);
        }

        public async Task<bool> Delete(int id)
        {
            bool toReturn = false;

            const string query = "";

            using (SqlConnection myConnection = new SqlConnection(""))
            {
                await myConnection.OpenAsync();
                using (SqlCommand myCommand = new SqlCommand(query, myConnection))
                {
                    myCommand.Parameters.AddWithValue("@id", id);

                    var result = await myCommand.ExecuteNonQueryAsync();
                    if (result >= 1)
                        toReturn = true;
                }
            }

            return (toReturn);
        }
    }
}
