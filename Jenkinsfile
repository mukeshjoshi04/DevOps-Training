pipeline
  {
  agent any
stages{

    stage('Checkout')
	{
		steps
		{
			env.WORKSPACE = 'C:\test'
			{
			 bat '''
			  git log -1 >lastcommit.txt
			  git name-rev --name-only HEAD > GIT_BRANCH
			 '''				
			powershell '''
			Start-Sleep -s 100
			'''
			}
		}
	}
	
    stage('Build Solution')
	{
		steps
		{
		 bat 'dotnet clean'
		 bat 'dotnet build'
		}
	}
	
    stage('Unit Testing and Code Coverage')
		{
		steps
		  {
			powershell 'C:/Users/mukeshjoshi/AppData/Local/Apps/OpenCover/OpenCover.Console.exe -target:"dotnet.exe" -output:coverage.xml -filter:"+[DemoDotNETCoreApplication*]* -[*.Tests*]*" -targetargs:"test" -register:user -oldstyle'
		  }
		}

	stage ('SonarQube Analysis')
      	{
         steps
		 {
			 withSonarQubeEnv('SonarQube')
			 {
			  powershell '''
			  dotnet C:/Users/mukeshjoshi/Desktop/sonar-scanner-msbuild-4.6.0.1930-netcoreapp2.0/SonarScanner.MSBuild.dll begin /k:"dotnetcoreproject" /d:sonar.cs.opencover.reportsPaths="coverage.xml"
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
		stage ('Download last successfull artifact')
      	{
         steps
		 {
		 powershell '''
		 Invoke-WebRequest "http://jenkins.intra.lutron.com:8080/job/rockhopper/job/Vive/job/Vive_GUI/job/GUI_Build_Pipeline/job/develop/lastSuccessfulBuild/artifact/*zip*/archive.zip" -UseBasicParsing -OutFile last_successfull_artifact.zip;
		 '''
		 } 	
      	}
		
	
      }
  }
