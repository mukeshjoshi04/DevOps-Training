pipeline
  {
  agent any
stages{
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
	stage ('SonarQube Analysis')
      	{
         steps
		 {
			 withSonarQubeEnv('SonarQube')
			 {
			  powershell '''
			  dotnet ${sonarscanner}//SonarScanner.MSBuild.dll begin /k:"dotnetcoreproject"
			  dotnet build DemoDotNETCoreApplication.sln
			  dotnet ${sonarscanner}//SonarScanner.MSBuild.dll end
			  '''
			 } 
		 }	
      	}
      }
  }
