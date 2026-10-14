# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and restore
COPY . ./
RUN dotnet restore ERPW.sln

# Publish the Blazor Server project
RUN dotnet publish ERPW.Web/ERPW.Web.csproj -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:80

COPY --from=build /app/publish ./

EXPOSE 80

ENTRYPOINT ["dotnet", "ERPW.Web.dll"]
