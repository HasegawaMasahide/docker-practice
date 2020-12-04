FROM mcr.microsoft.com/dotnet/aspnet:2.1

COPY App/bin/Release/netcoreapp2.1/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "NetCore.Docker.dll"]