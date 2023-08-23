pipeline {
    agent any
    stages {
        stage('Build') {
            tools {
                dotnetsdk 'dotnet-sdk-7.0'
            }
            steps {
                echo 'Building..'
                sh '''
                dotnet build Gamestore.client.sln
                '''
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
                sh '''
                echo "Testing Successfull.."
                '''
            }
        }
        stage('Deliver') {
            steps {
                echo 'Deliver....'
                sh '''
                echo "doing delivery stuff.."
                '''
            }
        }
    }
}
