using Newtonsoft.Json;
using RestSharp;
using System;

namespace APIDemo
{
    public class Demo
    {
        public ListOfUserDTO GetUsers()
        {
            var restClient = new RestClient("https://reqres.in");
            var restRequest = new RestRequest("api/users?page=2", Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            //Each Data will be Mapped to ListOfUsersDTO Class
            var users = JsonConvert.DeserializeObject<ListOfUserDTO>(content);
            return users;
        }

        public CreateUsersDTO CreateUsers()
        {
            var restClient = new RestClient("https://reqres.in");
            var restRequest = new RestRequest("/api/users", Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            //Each Data will be Mapped to ListOfUsersDTO Class
            var users = JsonConvert.DeserializeObject<ListOfUserDTO>(content);
            return users;
        }


    }
}
