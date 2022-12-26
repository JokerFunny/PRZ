FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine as build
WORKDIR /src
COPY JotterAPI/ .
RUN dotnet restore JotterAPI/JotterAPI.csproj
RUN dotnet publish JotterAPI/JotterAPI.csproj -c Release -o output

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine as runtime
WORKDIR /output
COPY --from=build /src/output .
ENTRYPOINT [ "dotnet", "JotterAPI.dll" ]