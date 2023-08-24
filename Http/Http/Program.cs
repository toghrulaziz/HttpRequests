using Http;
using System.Text;
using System.Text.Json;

HttpClient client = new();


#region HttpPost

//Post post = new()
//{
//    UserId = 1,
//    Id = 101,
//    Title = "Sample Post",
//    Body = "This is a sample post body."
//};

//string json = JsonSerializer.Serialize(post);

//StringContent content = new(json, Encoding.UTF8, "application/json");

//HttpResponseMessage response = await client.PostAsync("https://jsonplaceholder.typicode.com/posts", content);


//if (response.IsSuccessStatusCode)
//{
//    Console.WriteLine("POST request successful.");
//}
//else
//{
//    Console.WriteLine($"POST request failed with status code: {response.StatusCode}");
//}

#endregion


#region HttpDelete

//HttpResponseMessage response = await client.DeleteAsync("https://jsonplaceholder.typicode.com/posts/1");

//if (response.IsSuccessStatusCode)
//{
//    Console.WriteLine("DELETE request successful.");
//}
//else
//{
//    Console.WriteLine($"DELETE request failed with status code: {response.StatusCode}");
//}

#endregion



#region HttpPut

Post putdata = new()
{
    UserId = 1,
    Id = 1,
    Title = "Updated Post Title",
    Body = "This is an updated post body."
};


string json = JsonSerializer.Serialize(putdata);

StringContent content = new(json,Encoding.UTF8, "application/json");

HttpResponseMessage response = await client.PutAsync("https://jsonplaceholder.typicode.com/posts/1", content);

if (response.IsSuccessStatusCode)
{
    Console.WriteLine("PUT request successful.");
}
else
{
    Console.WriteLine($"PUT request failed with status code: {response.StatusCode}");
}


#endregion