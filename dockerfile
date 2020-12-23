FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

WORKDIR /app

COPY . ./

RUN dotnet publish -c Release -o out

WORKDIR /app

ENTRYPOINT ["dotnet", "run", "DiscordBot.dll"]