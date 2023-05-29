#FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
#WORKDIR /app
#
#EXPOSE 80
#EXPOSE 443
#EXPOSE 7166
#EXPOSE 5086
#
#FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
#WORKDIR /src
#COPY ["/webserver.csproj", "webserver/"]
#RUN dotnet restore "webserver/webserver.csproj"
#COPY . .
#WORKDIR "/src/webserver"
#RUN dotnet build "/webserver/webserver.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "webserver.csproj" -c Release -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "webserver.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT=Development

EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY webserver/webserver.csproj webserver/

RUN dotnet restore "webserver"
COPY . .
RUN dotnet build "webserver/webserver.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "webserver/" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "webserver.dll"]