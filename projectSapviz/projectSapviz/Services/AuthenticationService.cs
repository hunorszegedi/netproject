namespace projectSapviz.Services
{
    public class AuthenticationService
    {
        private readonly Dictionary<string, string> _users = new()
        {
            { "diak@example.com", "1234" }
        };

        public string? CurrentUser { get; private set; }

        public bool IsLoggedIn => !string.IsNullOrWhiteSpace(CurrentUser);

        public Task<bool> LoginAsync(string email, string code)
        {
            var ok = _users.TryGetValue(email, out var storedCode) && storedCode == code;
            if (ok)
            {
                CurrentUser = email;
            }
            return Task.FromResult(ok);
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
