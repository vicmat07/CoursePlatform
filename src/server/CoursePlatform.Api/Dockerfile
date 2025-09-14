# ===============================
# 1. Restore
# ===============================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS restore
WORKDIR /app

# Copia solution e projetos
COPY CoursePlatform.sln ./
COPY src/server/CoursePlatform.Api/CoursePlatform.Api.csproj CoursePlatform.Api/
COPY src/server/CoursePlatform.Application/CoursePlatform.Application.csproj CoursePlatform.Application/
COPY src/server/CoursePlatform.Domain/CoursePlatform.Domain.csproj CoursePlatform.Domain/
COPY src/server/CoursePlatform.Infrastructure/CoursePlatform.Infrastructure.csproj CoursePlatform.Infrastructure/

# Restaura pacotes do projeto Api
RUN dotnet restore CoursePlatform.Api/CoursePlatform.Api.csproj

# ===============================
# 2. Build
# ===============================
FROM restore AS build
COPY . .
WORKDIR /app/src/server/CoursePlatform.Api
RUN dotnet build -c Release

# ===============================
# 3. Publish
# ===============================
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

# ===============================
# 4. Runtime
# ===============================
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoursePlatform.Api.dll"]
