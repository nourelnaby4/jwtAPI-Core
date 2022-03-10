﻿namespace API_JWT.Models
{
    public class AuthModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool IsAuthentecated { get; set; }
        public List<string> Roles { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
