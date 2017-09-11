asp-net-generic-portal-gateway
==============================

Generic portal gateway is based on .NET technology, ASP.NET MVC (Model View Controller), IIS custom HTTP module, C# language and standard HTML/CSS.

The gateway functions as a portal gateway for authenticated and authorized users to an external site using TLS (i.e., a secure web proxy server). Authentication is based on password verification of user accounts stored in Active Directory and authorization on consuming a REST-ful service (which searches for user roles in a CSV-formatted file).

Furthermore, the IIS custom HTTP module is used to inject custom HTTP header fields in HTTP requests to the external site.