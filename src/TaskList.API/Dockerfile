FROM mcr.microsoft.com/dotnet/aspnet:8.0.1-jammy AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0.101-jammy AS build
WORKDIR /src
COPY ["TaskList.API/TaskList.API.csproj", "TaskList.API/"]
RUN dotnet restore "TaskList.API/TaskList.API.csproj"
COPY . .
WORKDIR "/src/TaskList.API"
RUN dotnet build "TaskList.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TaskList.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TaskList.API.dll"]