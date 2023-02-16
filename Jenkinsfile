pipeline {
	agent none
  environment {
        DOTNET_CLI_HOME = "/tmp/DOTNET_CLI_HOME"
        XDG_DATA_HOME = "/tmp"
}
  stages {
  	stage('dotnet build') {
    	agent {
      	docker {
        	image 'mcr.microsoft.com/dotnet/sdk:6.0'
        }
      }
      steps {
      	sh 'dotnet build'
      }
    }
  }
}