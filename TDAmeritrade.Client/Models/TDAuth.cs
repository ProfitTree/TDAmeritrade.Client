using System;

namespace TDAmeritrade.Client.Models
{
    public class TDAuth
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string TokenType { get; set; }
        public string Scope { get; set; }
        public string Code { get; set; }
        public string ConsumerKey { get; set; }
        public string RedirectUrl { get; set; }
        public int ExpiresIn { get; set; }
        public int RefreshTokenExpiresIn { get; set; }
        public DateTime Expires { get; set; }
        public DateTime RefreshTokenExpires { get; set; }
    }
}
