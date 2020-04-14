node('master') {
    
stage('pull'){
git 'https://github.com/subbudatta/SampleC-.git'
}
stage('restore')
{//may need to change nuget path
    bat label: '', script: '"C:\\ProgramData\\chocolatey\\bin\\nuget.exe" restore numberGuesser.sln'
}
stage('build')
{
   bat label: '', script: '''
"D:\\installed sw\\VSIUAL STUDIO\\MSBuild\\Current\\Bin\\MSBuild.exe" "%WORKSPACE%\\numberGuesser.sln" -t:clean -p:Configuration=Debug'''
}
//This was a test Ignore Following Code
// stage('run')
// {
//  bat label: '', script: '""%WORKSPACE%\\numberGuesser.exe"'
// }
}
