FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["RestaurantPOS/RestaurantPOS.csproj", "RestaurantPOS/"]
RUN dotnet restore "RestaurantPOS/RestaurantPOS.csproj"
COPY . .
WORKDIR "/src/RestaurantPOS"
RUN dotnet build "RestaurantPOS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestaurantPOS.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "RestaurantPOS.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet RestaurantPOS.dll