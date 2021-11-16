FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5001

ENV ASPNETCORE_URLS=http://+:5001

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MvcMovie.csproj", "./"]
RUN dotnet restore "MvcMovie.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "MvcMovie.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MvcMovie.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MvcMovie.dll"]
