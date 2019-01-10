dotnet "C:\Users\lcontesini\Documents\Ferramentas de Teste\SonarQube-Scanner\sonar-scanner-msbuild-4.5.0.1761-netcoreapp2.0\SonarScanner.MSBuild.dll" begin /k:"vicelulas"

dotnet build "C:\vicelulas\Back-end\Vicelulas\Vicelulas.sln"

dotnet "C:\Users\lcontesini\Documents\Ferramentas de Teste\SonarQube-Scanner\sonar-scanner-msbuild-4.5.0.1761-netcoreapp2.0\SonarScanner.MSBuild.dll" end

pause