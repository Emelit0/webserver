FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

# Remove this line if not running development
ENV APPNETCORE_ENVIRONMENT=Development

WORKDIR /app

EXPOSE 80
EXPOSE 443
EXPOSE 7166
EXPOSE 5086

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["webserver/webserver.csproj", "webserver/"]
RUN dotnet restore "webserver/webserver.csproj"
COPY . .
WORKDIR "/src/webserver"
RUN dotnet build "webserver.csproj" -c Release -o /app/build

COPY --from=build /root/.dotnet/corefx/cryptography/x509stores/my/* /root/.dotnet/corefx/cryptography/x509stores/my/

FROM build AS publish
RUN dotnet publish "webserver.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "webserver.dll"]
