namespace JotterAPI.Helpers.Abstractions
{
    public interface IPasswordHasher
	{
		(string hash, string salt) HashPassword(string password);
		bool ArePasswordsTheSame(string password, string saltString, string hashString);
	}
}
