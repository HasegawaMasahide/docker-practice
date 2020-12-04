FROM mcr.microsoft.com/dotnet/aspnet:2.1

COPY app/bin/Debug/netcoreapp2.1/publish/ app/
WORKDIR /app
ENTRYPOINT ["dotnet", "app.dll"]