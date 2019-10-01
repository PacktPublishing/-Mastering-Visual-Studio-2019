FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["FSharpWeb/FSharpWeb.fsproj", "FSharpWeb/"]
RUN dotnet restore "FSharpWeb/FSharpWeb.fsproj"
COPY . .
WORKDIR "/src/FSharpWeb"
RUN dotnet build "FSharpWeb.fsproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "FSharpWeb.fsproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FSharpWeb.dll"]