﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebServer.Domain/WebServer.Domain.csproj", "WebServer.Domain/"]
RUN dotnet restore "WebServer.Domain/WebServer.Domain.csproj"
COPY . .
WORKDIR "/src/WebServer.Domain"
RUN dotnet build "WebServer.Domain.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebServer.Domain.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebServer.Domain.dll"]
