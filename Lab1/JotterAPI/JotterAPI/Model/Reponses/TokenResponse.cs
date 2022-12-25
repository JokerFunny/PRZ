namespace JotterAPI.Model.Reponses
{
    public class TokenResponse : ResponseResult
    {
        public string AccessToken { get; set; }

        public TokenResponse(string token)
        {
            AccessToken = token;
        }
    }
}
