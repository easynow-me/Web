FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["EasyNow.Web/EasyNow.Web.csproj", "EasyNow.Web/"]
RUN dotnet restore "EasyNow.Web/EasyNow.Web.csproj"
COPY . .
WORKDIR "/src/EasyNow.Web"
RUN dotnet build "EasyNow.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EasyNow.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EasyNow.Web.dll"]