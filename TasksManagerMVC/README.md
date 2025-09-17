

https://blog.medhat.ca/2025/06/mcp-server-that-connects-your-vs-code.html

```
docker run --cap-add SYS_PTRACE -e ACCEPT_EULA=1 -e MSSQL_SA_PASSWORD=SqlPassword! -p 1333:1433 --name nw -d melmasry/my-sqlserver-northwind:latest
```
