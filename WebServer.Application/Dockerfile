FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebServer.Application/WebServer.Application.csproj", "WebServer.Application/"]
RUN dotnet restore "WebServer.Application/WebServer.Application.csproj"
COPY . .
WORKDIR "/src/WebServer.Application"
RUN dotnet build "WebServer.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebServer.Application.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebServer.Application.dll"]
