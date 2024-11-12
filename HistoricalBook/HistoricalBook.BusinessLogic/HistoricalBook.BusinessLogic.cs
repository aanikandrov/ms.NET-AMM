﻿<Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    </PropertyGroup>

    <ItemGroup>
    <ProjectReference Include="..\HistoricalBook.DataAccess\HistoricalBook.DataAccess.csproj" />
    </ItemGroup>

    <ItemGroup>
    <PackageReference Include="AutoMapper" Version="12.0.1" />
    <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.1" />
    </ItemGroup>

    </Project>