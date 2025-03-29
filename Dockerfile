FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NguyenHuynhNam_2015/NguyenHuynhNam_2015.csproj", "NguyenHuynhNam_2015/"]
RUN dotnet restore "NguyenHuynhNam_2015/NguyenHuynhNam_2015.csproj"
COPY . .
WORKDIR "/src/NguyenHuynhNam_2015"
RUN dotnet build "NguyenHuynhNam_2015.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "NguyenHuynhNam_2015.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NguyenHuynhNam_2015.dll"]
