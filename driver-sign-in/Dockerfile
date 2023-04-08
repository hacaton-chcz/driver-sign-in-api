#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["driver-sign-in/driver-sign-in.csproj", "driver-sign-in/"]
RUN dotnet restore "driver-sign-in/driver-sign-in.csproj"
COPY . .
WORKDIR "/src/driver-sign-in"
RUN dotnet build "driver-sign-in.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "driver-sign-in.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "driver-sign-in.dll"]