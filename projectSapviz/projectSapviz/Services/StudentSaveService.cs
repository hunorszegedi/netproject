using System.Text.Json;
using projectSapviz.Models;
using Microsoft.JSInterop;

namespace projectSapviz.Services
{
    public class StudentSaveService
    {
        private readonly IJSRuntime _jsRuntime;
        private const string StorageKey = "students";

        public StudentSaveService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task SaveStudentAsync(StudentEntry entry)
        {
            // Jelenlegi lista betöltése
            var list = await LoadAllAsync();

            // Új diák hozzáadása a listához
            list.Add(entry);

            // Lista mentése JSON-ként
            var json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });

            // Mentés localStorage-ba
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", StorageKey, json);
        }

        public async Task<List<StudentEntry>> LoadAllAsync()
        {
            try
            {
                // JSON betöltése localStorage-ból
                var json = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", StorageKey);

                // Ha még nem létezik, üres lista
                if (string.IsNullOrEmpty(json))
                {
                    return new List<StudentEntry>();
                }

                // Deszerializálás
                return JsonSerializer.Deserialize<List<StudentEntry>>(json)
                    ?? new List<StudentEntry>();
            }
            catch
            {
                // Hiba esetén üres lista
                return new List<StudentEntry>();
            }
        }

        // Új metódus: összes diák törlése
        public async Task ClearAllStudentsAsync()
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", StorageKey);
        }
    }
}