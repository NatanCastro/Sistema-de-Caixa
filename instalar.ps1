winget install Microsoft.DotNet.SDK.7
winget install SQLite.SQLite
. $PROFILE
$caminho = $env:userprofile + '\bin\sistema-de-caixa'
mkdir $caminho
Copy-Item '.\Banco de dados\caixa.sql' $caminho
Set-Location -Path $caminho
dotnet.exe publish '.\Sistema de Caixa.sln' -o $caminho
New-Item -Path $caminho -Name caixa.sqlite3
type caixa.sql | sqlite3 caixa.sqlite3

