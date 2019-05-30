# Docker-Compose-Nginx-NetCore
An example application using Nginx reverse proxy to a DotNet Core WebApp

## Requires
- Docker

## Execution
- Clone Code
- Build the image by using `docker-compose build` in the root folder (next to the `docker-compose.yml` file)
- Run the environment by using `docker-compose up`
- Access the WebApp via Localhost proxied by Nginx (it will show the passthrough in the console where you executed `docker-compose up`

## Remarks
If you experience issues with the proxy service starting up and it's complaining about binding to port 80

1. Make sure nothing else is active on Port 80 (either change the binding or stop the other service)
2. Docker for Windows has an issue with binding ports stop all containers and restart Docker for Windows

```powershell
docker-compose down
```

```powershell
docker stop $(docker ps -a -q)
```
