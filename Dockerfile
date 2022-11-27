FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
EXPOSE 5009

# Copy everything
COPY ./ ./

# Build and publish a release
RUN dotnet restore beeWebHooksAPI.csproj

RUN dotnet publish beeWebHooksAPI.csproj -c Release -o out --no-restore -p:UseAppHost=false

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "beeWebHooksAPI.dll"]
EXPOSE 5009