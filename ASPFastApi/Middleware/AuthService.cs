namespace ASPFastApi.Middleware;

public static class AuthService
{
    public static async Task<bool> CredentialsAreValid(string UserName, string Password, CancellationToken ct)
    {
        return true;
    }
}