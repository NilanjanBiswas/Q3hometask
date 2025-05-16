**********************************************************************
** Visual Studio 2022 Developer Command Prompt v17.5.3
** Copyright (c) 2022 Microsoft Corporation
**********************************************************************

C:\Users\nilan\source\repos\Q3hometask\MinimalAPI>curl -i http://localhost:5275/todos
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Date: Fri, 16 May 2025 16:37:03 GMT
Server: Kestrel
Transfer-Encoding: chunked

[]
C:\Users\nilan\source\repos\Q3hometask\MinimalAPI>curl -i -X POST http://localhost:5275/todos -H "Content-Type: application/json" -d "{\"text\":\"Buy milk\"}"
HTTP/1.1 201 Created
Content-Type: application/json; charset=utf-8
Date: Fri, 16 May 2025 16:37:14 GMT
Server: Kestrel
Location: /todos/8ab1531a-d329-4a5d-9b45-a7ebc5d62787
Transfer-Encoding: chunked

{"id":"8ab1531a-d329-4a5d-9b45-a7ebc5d62787","text":"Buy milk","isComplete":false,"createdAt":"2025-05-16T16:37:15.3013639Z"}
C:\Users\nilan\source\repos\Q3hometask\MinimalAPI>curl -i http://localhost:5275/todos/<id>
The syntax of the command is incorrect.

C:\Users\nilan\source\repos\Q3hometask\MinimalAPI>curl -i http://localhost:5275/todos/<id>

C:\Users\nilan\source\repos\Q3hometask\MinimalAPI>curl -i http://localhost:5275/todos/<

C:\Users\nilan\source\repos\Q3hometask\MinimalAPI>

C:\Users\nilan\source\repos\Q3hometask\MinimalAPI>

C:\Users\nilan\source\repos\Q3hometask\MinimalAPI>curl -i http://localhost:5275/todos/8ab1531a-d329-4a5d-9b45-a7ebc5d62787
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Date: Fri, 16 May 2025 16:40:09 GMT
Server: Kestrel
Transfer-Encoding: chunked

{"id":"8ab1531a-d329-4a5d-9b45-a7ebc5d62787","text":"Buy milk","isComplete":false,"createdAt":"2025-05-16T16:37:15.3013639Z"}
C:\Users\nilan\source\repos\Q3hometask\MinimalAPI>curl -i -X PUT http://localhost:5275/todos/8ab1531a-d329-4a5d-9b45-a7ebc5d62787 ^
More?      -H "Content-Type: application/json" ^
More?      -d "{\"text\":\"Buy bread\",\"isComplete\":true}"
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Date: Fri, 16 May 2025 16:40:26 GMT
Server: Kestrel
Transfer-Encoding: chunked

{"id":"8ab1531a-d329-4a5d-9b45-a7ebc5d62787","text":"Buy bread","isComplete":true,"createdAt":"2025-05-16T16:37:15.3013639Z"}
C:\Users\nilan\source\repos\Q3hometask\MinimalAPI>curl -i -X DELETE http://localhost:5275/todos/8ab1531a-d329-4a5d-9b45-a7ebc5d62787
HTTP/1.1 204 No Content
Date: Fri, 16 May 2025 16:40:46 GMT
Server: Kestrel


C:\Users\nilan\source\repos\Q3hometask\MinimalAPI>curl -i http://localhost:5275/todos >> curl-logs.txt
  % Total    % Received % Xferd  Average Speed   Time    Time     Time  Current
                                 Dload  Upload   Total   Spent    Left  Speed
100     2    0     2    0     0     28      0 --:--:-- --:--:-- --:--:--    28

C:\Users\nilan\source\repos\Q3hometask\MinimalAPI>
