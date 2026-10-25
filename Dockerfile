FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY colitasFelices.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish colitasFelices.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000

ENTRYPOINT ["dotnet", "colitasFelices.dll"]