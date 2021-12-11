FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["My-Console-App/My-Console-App.csproj", "My-Console-App/"]
RUN dotnet restore "My-Console-App/My-Console-App.csproj"
COPY . .
WORKDIR "/src/My-Console-App"
RUN dotnet build "My-Console-App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "My-Console-App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "My-Console-App.dll"]
