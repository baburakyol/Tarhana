using System;
using System.Collections.Generic;

namespace Tarhana.Web
{
    public class AppTenant
    {
        public AppTenant() {
            Id = Guid.NewGuid();
            Master = true;
            Name = "bulonline";
            NavbarBrand = "Bul Online";
            Theme = "bulonline";
        }

        public Guid Id { get; set; }
        public bool Master { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Navbar Header
        /// Forget Password Email Template Gönderici Adı
        /// </summary>
        public string NavbarBrand { get; set; }
        public List<string> HostNames { get; set; }
        public string Theme { get; set; }
        public string csstheme { get; set; }
        public string folder { get; set; }
        public bool subdomain { get; set; }
        public string ConnectionString { get; set; }

        /// <summary>
        /// Mailing de from address
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Footer email image
        /// </summary>
        public string emailimage { get; set; }
        public string logoimage { get; set; }
        public EmailAccount EmailAccount { get; set; }
        public SocialAuthentication FacebookAuth { get; set; }
        public SocialAuthentication GoogleAuth { get; set; }
        public SocialAuthentication TwitterAuth { get; set; }
        public SocialAuthentication MicrosoftAuth { get; set; }
        public SocialAuthentication InstagramAuth { get; set; }

    }

    public class SocialAuthentication
    {
        public bool enabled { get; set; }

        public string account { get; set; }
        public string secret { get; set; }
    }


    public partial class EmailAccount
    {
        /// <summary>
        /// Gets or sets an email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets an email display name
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets an email host
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets an email port
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets an email user name
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets an email password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value that controls whether the SmtpClient uses Secure Sockets Layer (SSL) to encrypt the connection
        /// </summary>
        public bool EnableSsl { get; set; }

        /// <summary>
        /// Gets or sets a value that controls whether the default system credentials of the application are sent with requests.
        /// </summary>
        public bool UseDefaultCredentials { get; set; }

        /// <summary>
        /// Gets a friendly email account name
        /// </summary>
        public string FriendlyName
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.DisplayName))
                    return this.Email + " (" + this.DisplayName + ")";
                return this.Email;
            }
        }
    }
}