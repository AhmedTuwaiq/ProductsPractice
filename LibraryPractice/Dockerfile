FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["LibraryPractice/LibraryPractice.csproj", "LibraryPractice/"]
RUN dotnet restore "LibraryPractice/LibraryPractice.csproj"
COPY . .
WORKDIR "/src/LibraryPractice"
RUN dotnet build "LibraryPractice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LibraryPractice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LibraryPractice.dll"]
