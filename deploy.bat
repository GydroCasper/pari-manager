cd ./client
ng build --prod
aws s3 cp ./dist/pari-manager s3://pm-solution --recursive --profile gydrocasper
cd ..
cd ./server/PariMan.Lambda.GetList
dotnet build
dotnet lambda deploy-function pariMan-get-list --profile gydrocasper
cd ../..
cd ./server/PariMan.Lambda.GetPari
dotnet build
dotnet lambda deploy-function pariMan-get-pari --profile gydrocasper
cd ../..
cd ./server/PariMan.Lambda.ExecuteCommand
dotnet build
dotnet lambda deploy-function pariMan-execute-command --profile gydrocasper
dir

