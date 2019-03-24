FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["DemoDotNETCoreApplication/DemoDotNETCoreApplication.csproj", "DemoDotNETCoreApplication/"]
RUN dotnet restore "DemoDotNETCoreApplication/DemoDotNETCoreApplication.csproj"
COPY . .

WORKDIR "/src/DemoDotNETCoreApplication"
RUN dotnet build "DemoDotNETCoreApplication.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DemoDotNETCoreApplication.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DemoDotNETCoreApplication.dll"]