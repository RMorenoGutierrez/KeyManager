FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["KeyManager.Web/KeyManager.Web.csproj", "KeyManager.Web/"]
RUN dotnet restore "KeyManager.Web/KeyManager.Web.csproj"
COPY . .
WORKDIR "/src/KeyManager.Web"
RUN dotnet build "KeyManager.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "KeyManager.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "KeyManager.Web.dll"]