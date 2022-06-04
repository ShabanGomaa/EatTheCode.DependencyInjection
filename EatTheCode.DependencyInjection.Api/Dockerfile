#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["EatTheCode.DependencyInjection.Api/EatTheCode.DependencyInjection.Api.csproj", "EatTheCode.DependencyInjection.Api/"]
RUN dotnet restore "EatTheCode.DependencyInjection.Api/EatTheCode.DependencyInjection.Api.csproj"
COPY . .
WORKDIR "/src/EatTheCode.DependencyInjection.Api"
RUN dotnet build "EatTheCode.DependencyInjection.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EatTheCode.DependencyInjection.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EatTheCode.DependencyInjection.Api.dll"]