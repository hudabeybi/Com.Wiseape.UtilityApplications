<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="14.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuild<% me.say(Project.ProjectName); %>Version)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuild<% me.say(Project.ProjectName); %>Version)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{9D62477D-D5EF-4351-8F88-8FFE748CA7EB}</ProjectGuid>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.<% me.say(Module.ModuleName); %>.View.Service</RootNamespace>
    <AssemblyName>Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.<% me.say(Module.ModuleName); %>.View.Service</AssemblyName>
    <TargetFrameworkVersion>v4.5.2</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System.Data" />
    <Reference Include="System.Net.Http" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Properties\AssemblyInfo.cs" />
	<Compile Include="Validator\*.cs" />
  </ItemGroup>
  <ItemGroup>
    <ProjectReference Include="..\..\Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.Shared\Com.<% me.say(Project.CompanyName); %>.Libraries\Com.<% me.say(Project.CompanyName); %>.Framework\Com.<% me.say(Project.CompanyName); %>.Framework.csproj">
      <Project>{ea7e701b-2adf-48f9-98bb-a24b57e988f6}</Project>
      <Name>Com.<% me.say(Project.CompanyName); %>.Framework</Name>
    </ProjectReference>
    <ProjectReference Include="..\..\Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.Shared\Com.<% me.say(Project.CompanyName); %>.Libraries\Com.<% me.say(Project.CompanyName); %>.Utility\Com.<% me.say(Project.CompanyName); %>.Utility.csproj">
      <Project>{810642a3-d345-4864-b6f7-1eb04c2b06cf}</Project>
      <Name>Com.<% me.say(Project.CompanyName); %>.Utility</Name>
    </ProjectReference>
    <ProjectReference Include="..\..\Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.Shared\Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.Data\Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.Data.csproj">
      <Project>{7e3aae64-566f-491d-970c-8598fd24923b}</Project>
      <Name>Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.Data</Name>
    </ProjectReference>
    <ProjectReference Include="..\Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.<% me.say(Module.ModuleName); %>.View.Contract\Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.<% me.say(Module.ModuleName); %>.View.Contract.csproj">
      <Project>{8f3596b1-6e74-4b7c-9b56-ddd5ca36d524}</Project>
      <Name>Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.<% me.say(Module.ModuleName); %>.View.Contract</Name>
    </ProjectReference>
    <ProjectReference Include="..\Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.<% me.say(Module.ModuleName); %>.View.Model\Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.<% me.say(Module.ModuleName); %>.View.Model.csproj">
      <Project>{da836edd-4fff-43b9-980d-abed8afdf717}</Project>
      <Name>Com.<% me.say(Project.CompanyName); %>.<% me.say(Project.ProjectName); %>.<% me.say(Module.ModuleName); %>.View.Model</Name>
    </ProjectReference>
  </ItemGroup>
  <ItemGroup>
    <Folder Include="Validator\" />
  </ItemGroup>

  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>