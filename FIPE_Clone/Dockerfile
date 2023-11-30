#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FIPE_Clone/FIPE_Clone.csproj", "FIPE_Clone/"]
RUN dotnet restore "FIPE_Clone/FIPE_Clone.csproj"
COPY . .
WORKDIR "/src/FIPE_Clone"
RUN dotnet build "FIPE_Clone.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FIPE_Clone.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FIPE_Clone.dll"]