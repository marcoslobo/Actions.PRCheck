#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Actions.PRCheck/Actions.PRCheck.csproj", "src/Actions.PRCheck/"]
RUN dotnet restore "src/Actions.PRCheck/Actions.PRCheck.csproj"
COPY . .
WORKDIR "/src/src/Actions.PRCheck"
RUN dotnet build "Actions.PRCheck.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Actions.PRCheck.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Actions.PRCheck.dll"]