#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/WebPruebaApi/WebPruebaApi.csproj", "src/WebPruebaApi/"]
COPY ["src/Application/Application.csproj", "src/Application/"]
COPY ["src/Domain/Domain.csproj", "src/Domain/"]
COPY ["src/Persistence/Persistence.csproj", "src/Persistence/"]
RUN dotnet restore "src/WebPruebaApi/WebPruebaApi.csproj"
COPY . .
WORKDIR "/src/src/WebPruebaApi"
RUN dotnet build "WebPruebaApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebPruebaApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY ["src/WebPruebaApi/Plantillas/*", "/app/Plantillas/"]
RUN ["mkdir", "/app/FilesDocsTmp/"]
RUN ["mkdir", "/app/Archivos/"]

ENTRYPOINT ["dotnet", "WebPruebaApi.dll"]