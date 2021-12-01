using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using OpenAir.Shared.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenAir.Client.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthenticationService(HttpClient client,
                                     AuthenticationStateProvider authStateProvider,
                                     ILocalStorageService localStorage)
        {
            _client = client;
            _authStateProvider = authStateProvider;
            _localStorage = localStorage;
        }

        // Login metode
        public async Task<AuthenticatedUserModel> Login(AuthenticationUserModel userForAuthentication)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", userForAuthentication.Email),
                new KeyValuePair<string, string>("password", userForAuthentication.Password)
            });

            var authResult = await _client.PostAsync("https://localhost:5001/token", data);
            var authContext = await authResult.Content.ReadAsStringAsync();

            if (authResult.IsSuccessStatusCode == false)
                return null;

            var result = JsonSerializer.Deserialize<AuthenticatedUserModel>(authContext);

            await _localStorage.SetItemAsync("authToken", result.Access_Token);

            ((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(result.Access_Token);

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.Access_Token);

            return result;
        }

        // Logout metode
        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((AuthStateProvider)_authStateProvider).NotifyUserLogout();

            _client.DefaultRequestHeaders.Authorization = null;
        }
    }
}
