# Zobacz https://aka.ms/customizecontainer, aby dowiedzieć się, jak dostosować kontener debugowania i jak program Visual Studio używa tego pliku Dockerfile do kompilowania obrazów w celu szybszego debugowania.

# W zależności od systemu operacyjnego maszyn hostów, które będą kompilować lub uruchamiać kontenery, może być konieczna zmiana obrazu określonego w instrukcji FROM.
# Aby uzyskać więcej informacji, zobacz https://aka.ms/containercompat

# Ten etap jest używany podczas uruchamiania z programu VS w trybie szybkim (domyślnie dla konfiguracji debugowania)
FROM mcr.microsoft.com/dotnet/runtime:10.0-nanoserver-ltsc2022 AS base
WORKDIR /app


# Ten etap służy do kompilowania projektu usługi
FROM mcr.microsoft.com/dotnet/sdk:10.0-nanoserver-ltsc2022 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["lab4.1/lab4.1.csproj", "lab4.1/"]
RUN dotnet restore "./lab4.1/lab4.1.csproj"
COPY . .
WORKDIR "/src/lab4.1"
RUN dotnet build "./lab4.1.csproj" -c %BUILD_CONFIGURATION% -o /app/build

# Ten etap służy do publikowania projektu usługi do skopiowania do etapu końcowego
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./lab4.1.csproj" -c %BUILD_CONFIGURATION% -o /app/publish /p:UseAppHost=false

# Ten etap jest używany w środowisku produkcyjnym lub w przypadku uruchamiania z programu VS w trybie regularnym (domyślnie, gdy nie jest używana konfiguracja debugowania)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lab4.1.dll"]