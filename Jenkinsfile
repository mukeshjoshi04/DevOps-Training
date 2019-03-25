pipeline
  {
  agent any
stages{
    stage ('Docker')
      	{
         steps
		 {
		 powershell 'docker build -t dotnetcoredemoapp:latest -f ./DemoDotNETCoreApplication/Dockerfile .'
		 powershell 'if($(docker ps -a | findstr My_Container)){ docker rm -f My_Container}'
		 powershell 'docker run --name dotnetcoredemo_container -d -p 9090:80 dotnetcoredemoapp'
		 } 	
      	}
      }
  }
