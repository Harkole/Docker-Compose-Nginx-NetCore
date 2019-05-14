# Docker-Compose-Nginx-NetCore
An example application using Nginx reverse proxy to a DotNet Core WebApp

## Requires
- Docker

## Execution
- Clone Code
- Build the image by using `docker-compose build` in the root folder (next to the `docker-compose.yml` file)
- Run the environment by using `docker-compose up`
- Access the WebApp via Localhost proxied by Nginx (it will show the passthrough in the console where you executed `docker-compose up`
