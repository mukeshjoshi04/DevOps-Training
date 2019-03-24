pipeline
  {
agent{ node("windows_slave")}
stages{
    stage ('Docker')
      {
         steps
		 {
		 bat 'docker build -t dotnetcoredemoapp:latest -f ./DemoDotNETCoreApplication/Dockerfile .'
		 } 	
      }
  }
post
    {
        success
        {
            mail to: "mukesh.joshi@nagarro.com",
            subject: "SUCCESS: ${currentBuild.fullDisplayName}",
            body: "Hurray! Your pipeline builded successfully ${env.BUILD_URL}"
        }
        failure
        {
            mail to: "mukesh.joshi@nagarro.com",
            subject: "FAIL : ${currentBuild.fullDisplayName}",
            body: "Something is wrong with ${env.BUILD_URL}"
        }
    } 
 

}

def SonarAnalysisStart()
{
echo  "\u2600 **********Sonar analysis started*****************"
withSonarQubeEnv("sonarqube")
    {
    bat "\"${tool 'Sonarscanner'}\\SonarScanner.MSBuild.exe\" begin /key:mukeshjoshi04 /n:MukeshJoshi /v:1.5"
    }
}

def SonarAnalysisStop()
{
echo  "\u2600 **********Sonar analysis ends*****************"
withSonarQubeEnv("sonarqube")
    {
    bat "\"${tool 'Sonarscanner'}\\SonarScanner.MSBuild.exe\" end"
    
    } 
}
