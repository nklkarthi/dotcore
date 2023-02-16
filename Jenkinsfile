pipeline {
	agent none
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