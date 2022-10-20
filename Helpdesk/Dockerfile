#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Helpdesk/Helpdesk.csproj", "Helpdesk/"]
RUN dotnet restore "Helpdesk/Helpdesk.csproj"
COPY . .
WORKDIR "/src/Helpdesk"
RUN dotnet build "Helpdesk.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Helpdesk.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Helpdesk.dll"]