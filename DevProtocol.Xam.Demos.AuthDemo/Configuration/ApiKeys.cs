using System;

namespace DevProtocol.Xam.Demos.AuthDemo.Configuration
{
	public static class ApiKeys
	{
	public const string ClientId = "Q0mxMu0s1HmcJt7hVVF1thg2xfEBRyuIXfIVIw4JVImdvKNxjP";
	public const string ClientSecret = "tOHwC3rgC1zI4suyvn9ijNssVoy92Tfr8FlDacDu";
	public const string RedirectUrl = "https://localhost:44319/signin-oidc";
	public const string Scope = "com.intuit.quickbooks.accounting email profile phone address openid";
	public const string AuthorizeUrl = "https://appcenter.intuit.com/connect/oauth2";
	public const string AccessTokenUrl = "https://oauth.platform.intuit.com/oauth2/v1/tokens/bearer";
	public const string BaseAuthorizationUrl = "https://appcenter.intuit.com/connect/oauth2";
	public const string ApiVersion = "2.0";
	public const string AccessToken = "access_token";
	}
}
