pipeline
  {
  agent
	  {
	   node("windows_slave")
	  }
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
