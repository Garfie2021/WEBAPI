## WEBAPI/Src_Swagger/
Change the version displayed on the Swagger web screen.

In the ASPNET Core Web API project, I made a sample that displays the version of Swagger included by default on the web screen in the project created with "Enable OpenAPI support" checked.

[Source code explanation page](https://blog.unikktle.com/swagger%e3%81%ae-web%e7%94%bb%e9%9d%a2%e3%81%ab%e8%a1%a8%e7%a4%ba%e3%81%95%e3%82%8c%e3%82%8b%e3%83%90%e3%83%bc%e3%82%b8%e3%83%a7%e3%83%b3%e3%82%92%e5%a4%89%e3%81%88%e3%82%8b/)

---

## WEBAPI/Src_Dapper_PostgreSQL_Transaction/

Simple and fast DB transaction processing implemented with ASP.NET Core Web API.

I created a sample that uses Dapper + Npgsql NuGet package from ASP.NET Core Web API of .Net 6 to perform DB transaction processing to PostgreSQL database.
This time, we implemented the database with PostgreSQL, but the implementation of DB transactions is the same for Oracle, SQLServer, and MySQL.

If business logic and database processing are implemented using Repository and Interface, the source code becomes complicated and maintainability decreases.
Implementing with a static class simplifies the source code and improves maintainability.
Unit tests are easy to implement for source code implemented with static classes.

There are too many projects that use repositories and interfaces to implement a large amount of useless processing, exploding man-hours and never ending development. Static should be used.
Even now, there are people who don't understand multithreading in C# and say "I'm worried about using static", and if that person's opinion is adopted and "static is prohibited", the development effort will explode.

[YouTube](https://youtu.be/0lsT82s-IHE)
[Source code explanation page](https://blog.unikktle.com/asp-net-core-web-api%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab%e3%81%a7%e9%ab%98%e9%80%9f%e3%81%aadb%e3%83%88%e3%83%a9%e3%83%b3%e3%82%b6%e3%82%af%e3%82%b7/)

---

## WEBAPI/Src_Dapper_SQLServer_Transaction/

I created a sample that uses Dapper + Microsoft.Data.SqlClient NuGet package from ASP.NET Core Web API of .Net 6.0 to perform DB transaction processing to SQLServer database.

If business logic and database processing are implemented using Repository and Interface, the source code becomes complicated and maintainability decreases.
Implementing with a static class simplifies the source code and improves maintainability.
Unit tests are easy to implement for source code implemented with static classes.
There are too many projects that use repositories and interfaces to implement a large amount of useless processing, exploding man-hours and never ending development. Static should be used.
Even now, there are people who don't understand multithreading in C# and say "I'm worried about using static", and if that person's opinion is adopted and "static is prohibited", the development effort will explode.

The Visual Studio project template used this time is Visual Studio 2022 + .Net 6 + ASP.NET Core Web API app without HTTPS.
Install the Dapper/Microsoft.Data.SqlClient NuGet package.

[YouTube](https://youtu.be/J8H8JCTv8OU)
[Source code explanation page](https://blog.unikktle.com/asp-net-core-web-api%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab%e3%81%a7%e9%ab%98%e9%80%9f%e3%81%aadb%e3%83%88%e3%83%a9%e3%83%b3%e3%82%b6%e3%82%af%e3%82%b7-2/)

---

## WEBAPI/Src_Dapper_ORACLE_Transaction/

I created a sample that uses Dapper+Oracle.EntityFrameworkCore NuGet package from .Net 6.0 ASP.NET Core Web API to perform DB transaction processing to ORACLE database.

If business logic and database processing are implemented using Repository and Interface, the source code becomes complicated and maintainability decreases.
Implementing with a static class simplifies the source code and improves maintainability.
Unit tests are easy to implement for source code implemented with static classes.
There are too many projects that use repositories and interfaces to implement a large amount of useless processing, exploding man-hours and never ending development. Static should be used.
Even now, there are people who don't understand multithreading in C# and say "I'm worried about using static", and if that person's opinion is adopted and "static is prohibited", the development effort will explode.

The Visual Studio project template used this time is Visual Studio 2022 + .Net 6 + ASP.NET Core Web API app without HTTPS.
Install Dapper/Oracle.EntityFrameworkCore NuGet package.

[YouTube](https://youtu.be/kBZDbSEdJAQ)
[Source code explanation page](https://blog.unikktle.com/asp-net-core-web-api%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab%e3%81%a7%e9%ab%98%e9%80%9f%e3%81%aadb%e3%83%88%e3%83%a9%e3%83%b3%e3%82%b6%e3%82%af%e3%82%b7-3/)

---

## WEBAPI/Src_Dapper_SQLServer_Transaction_StoredProcedure/

Simple and high-speed DB transaction processing (on SQLServer) implemented with ASP.NET Core Web API and stored procedures.

From ASP.NET Core Web API of .Net 6.0, using Dapper + Microsoft.Data.SqlClient NuGet package, I created a sample that performs DB transaction processing when using SQLServer database stored procedures.

[YouTube](https://youtu.be/Ipn1DbWFD7M)
[Source code explanation page](https://blog.unikktle.com/asp-net-core-web-api%e3%81%a8%e3%82%b9%e3%83%88%e3%82%a2%e3%83%89%e3%83%97%e3%83%ad%e3%82%b7%e3%83%bc%e3%82%b8%e3%83%a3%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab/)

---

