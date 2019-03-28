pipeline
  {
  agent any
stages{
<<<<<<< HEAD
    stage('Build Solution')
	{
		steps
		{
		 dotnet build DemoDotNETCoreApplication.sln
		}
	}	
   stage('Unit Testing and creating result.xml')
	{
		steps
		{
		powershell 'C:/Users/mukeshjoshi/AppData/Local/Apps/OpenCover/OpenCover.Console.exe -target:"C:/Program Files/dotnet/dotnet.exe" -targetargs:"test DemoDotNETCoreApplication.Tests.csproj" -register:user -oldstyle'
		}
	}
=======
	
>>>>>>> 3e68cf9a5ce6ce85a340da165d03bb8de9aed46b
	stage ('SonarQube Analysis')
      	{
         steps
		 {
			 withSonarQubeEnv('SonarQube')
			 {
			  powershell '''
<<<<<<< HEAD
			  dotnet C:/Users/mukeshjoshi/Desktop/sonar-scanner-msbuild-4.6.0.1930-netcoreapp2.0/SonarScanner.MSBuild.dll begin /k:"dotnetcoreproject /d:sonar.cs.opencover.reportsPaths="DemoDotNETCoreApplication.Tests/result.xml"
=======
			  dotnet C:/Users/mukeshjoshi/Desktop/sonar-scanner-msbuild-4.6.0.1930-netcoreapp2.0/SonarScanner.MSBuild.dll begin /k:"dotnetcoreproject"
>>>>>>> 3e68cf9a5ce6ce85a340da165d03bb8de9aed46b
			  dotnet build DemoDotNETCoreApplication.sln
			  dotnet C:/Users/mukeshjoshi/Desktop/sonar-scanner-msbuild-4.6.0.1930-netcoreapp2.0/SonarScanner.MSBuild.dll end
			  '''
			 } 
		 }	
      	}
	
    stage ('Docker')
      	{
         steps
		 {
		 powershell '''
		 docker build -t dotnetcoredemoapp:latest -f ./DemoDotNETCoreApplication/Dockerfile .
		 if($(docker ps -a | findstr dotnetcoredemo_container)){ docker rm -f dotnetcoredemo_container}
		 docker run --name dotnetcoredemo_container -d -p 9090:80 dotnetcoredemoapp
		 '''
		 } 	
      	}
	
      }
  }
