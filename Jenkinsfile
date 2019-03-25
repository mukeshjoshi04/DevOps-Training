pipeline
  {
  agent any
stages{
    stage ('Docker')
      	{
         steps
		 {
		 bat 'docker build -t dotnetcoredemoapp:latest -f ./DemoDotNETCoreApplication/Dockerfile .'
		 powershell 'docker run --name dotnetcoredemo_container -d -p 9090:80 dotnetcoredemoapp'
		 } 	
      	}
      }
  }
