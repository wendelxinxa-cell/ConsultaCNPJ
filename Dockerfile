# Usa a imagem oficial do SDK do .NET 8 para compilar
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia tudo da raiz (que agora é a pasta ERPW.Web)
COPY . .

# Restaura e publica o projeto diretamente
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

# Imagem final de runtime do .NET 8
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "ERPW.Web.dll"]
