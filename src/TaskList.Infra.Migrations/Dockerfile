FROM mcr.microsoft.com/dotnet/aspnet:8.0.1-jammy AS base
WORKDIR /app
EXPOSE 80

RUN apt-get update \
    && apt-get install -y postgresql-client \
    && rm -rf /var/lib/apt/lists/*

FROM mcr.microsoft.com/dotnet/sdk:8.0.101-jammy AS build
WORKDIR /src
COPY ["TaskList.Infra.Migrations/TaskList.Infra.Migrations.csproj", "TaskList.Infra.Migrations/"]
RUN dotnet restore "TaskList.Infra.Migrations/TaskList.Infra.Migrations.csproj"
COPY . .
WORKDIR "/src/TaskList.Infra.Migrations"
RUN dotnet build "TaskList.Infra.Migrations.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TaskList.Infra.Migrations.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

COPY ["TaskList.Infra.Migrations/docker-entrypoint.sh", "/usr/local/bin/"]
RUN chmod +x /usr/local/bin/docker-entrypoint.sh
ENTRYPOINT ["/usr/local/bin/docker-entrypoint.sh"]