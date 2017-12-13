echo SqlServer2017-latest
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Password00##" -p 1433:1433 --name sqlserver -d microsoft/mssql-server-linux:2017-latest
echo Started