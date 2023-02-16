#winget install Microsoft.DotNet.SDK.7
#winget install SQLite.SQLite
$caminho = $env:userprofile + '\bin\produto-curso'
mkdir $caminho
Copy-Item '.\Banco de dados\caixa.sql' $caminho
dotnet.exe publish '.\Sistema de Caixa.sln' -o $caminho -v q -c release
Set-Location -Path $caminho
type caixa.sql | sqlite3 caixa.sqlite3

