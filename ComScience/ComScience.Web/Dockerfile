FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . .
WORKDIR /src/ComScience.Web
RUN dotnet restore
RUN dotnet publish --no-restore -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
ENV ASPNETCORE_URLS=http://*:1100
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "ComScience.Web.dll"]