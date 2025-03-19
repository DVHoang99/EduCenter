# Stage 1: Build application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy only the project file first to restore dependencies separately
COPY EduCenterService.csproj ./
RUN dotnet restore

# Copy the entire source code after restoring dependencies
COPY . . 
RUN dotnet build "EduCenterService.csproj" -c Release -o /app/build

# Stage 2: Publish application
FROM build AS publish
RUN dotnet publish "EduCenterService.csproj" -c Release -o /app/publish

# Stage 3: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EduCenterService.dll"]
        