FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Core3Web/Core3Web.csproj", "Core3Web/"]
RUN dotnet restore "Core3Web/Core3Web.csproj"
COPY . .
WORKDIR "/src/Core3Web"
RUN dotnet build "Core3Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Core3Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Core3Web.dll"]