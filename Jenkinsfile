pipeline
  {
  agent any
stages{
    stage ('Docker')
      {
         steps
		 {
		 bat 'docker build -t dotnetcoredemoapp:latest -f ./DemoDotNETCoreApplication/Dockerfile .'
	         bat 'docker rm -f dotnetcoredemo_container || true'
		 bat 'docker run --name dotnetcoredemo_container -d -p 9090:80 dotnetcoredemoapp'
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
