using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json; // Newtonsoft.Json NuGet 패키지 필요

namespace WindowsFormsApp2.Services
{
    public class ApiService
    {
        // Supabase 설정 (실제 값은 사용자가 입력하거나 설정 파일에서 로드)
        private string _supabaseUrl = "https://tzmljcmhoceclbiehzos.supabase.co";
        private string _supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InR6bWxqY21ob2NlY2xiaWVoem9zIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTgwNzY1NDYsImV4cCI6MjA3MzY1MjU0Nn0.EaaeAATDq_n2vO9rF37H65m5P9Wn3kTDMkJkBcAwWKQ";

        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
            // Supabase 필수 헤더 추가
            // _httpClient.DefaultRequestHeaders.Add("apikey", _supabaseKey);
            // _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_supabaseKey}");
        }

        // URL과 키를 동적으로 설정할 수 있는 생성자 추가
        public ApiService(string url, string key)
        {
            _supabaseUrl = url;
            _supabaseKey = key;
            _httpClient = new HttpClient();
        }

        private void AddHeaders()
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("apikey", _supabaseKey);
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_supabaseKey}");
        }

        // GET: List
        public async Task<List<T>> GetAllAsync<T>(string endpoint)
        {
            AddHeaders();
            // Supabase REST API는 전체 URL이 필요함. endpoint가 "/rest/v1/table" 형태라고 가정하거나
            // endpoint가 전체 URL일 경우 처리. 여기서는 endpoint를 테이블명으로 받고 URL을 조합하는 방식 추천.
            // 하지만 기존 코드 호환성을 위해 endpoint가 전체 URL이면 그대로 쓰고, 아니면 조합.

            string requestUrl = endpoint.StartsWith("http") ? endpoint : $"{_supabaseUrl}{endpoint}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<T>>(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"API GET Error: {ex.Message}");
                throw;
            }
        }

        // GET: Single
        public async Task<T> GetAsync<T>(string endpoint)
        {
            AddHeaders();
            string requestUrl = endpoint.StartsWith("http") ? endpoint : $"{_supabaseUrl}{endpoint}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Supabase returns a list even for single item query usually, unless specific headers used.
                // Assuming endpoint includes query params for single item or returns object.
                // If it returns list [ {} ], we need to handle.
                // For simplicity, let's assume standard REST behavior or list.
                // If list, take first.
                try
                {
                    return JsonConvert.DeserializeObject<T>(responseBody);
                }
                catch
                {
                    var list = JsonConvert.DeserializeObject<List<T>>(responseBody);
                    return list != null && list.Count > 0 ? list[0] : default(T);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"API GET Single Error: {ex.Message}");
                throw;
            }
        }

        // POST: Create
        public async Task CreateAsync<T>(string endpoint, T data)
        {
            AddHeaders();
            string requestUrl = endpoint.StartsWith("http") ? endpoint : $"{_supabaseUrl}{endpoint}";

            try
            {
                string json = JsonConvert.SerializeObject(data);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                // Supabase Insert needs Prefer: return=minimal or representation
                _httpClient.DefaultRequestHeaders.Add("Prefer", "return=minimal");

                HttpResponseMessage response = await _httpClient.PostAsync(requestUrl, content);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"API POST Error: {ex.Message}");
                throw;
            }
        }

        // PUT: Update
        public async Task UpdateAsync<T>(string apiUrl, T data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PutAsync(apiUrl, content);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"API PUT Error: {ex.Message}");
                throw;
            }
        }

        // DELETE: Delete
        public async Task DeleteAsync(string apiUrl)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.DeleteAsync(apiUrl);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"API DELETE Error: {ex.Message}");
                throw;
            }
        }
    }
}
