FROM mcr.microsoft.com/dotnet/core/sdk:3.0.100-preview3 AS build
WORKDIR /app

COPY *.sln .
COPY HelloWorld/*.csproj ./HelloWorld/
RUN dotnet restore

COPY HelloWorld/. ./HelloWorld/

WORKDIR /app/HelloWorld
RUN dotnet publish -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0.0-preview3 AS runtime
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "HelloWorld.dll"]
EXPOSE 80
