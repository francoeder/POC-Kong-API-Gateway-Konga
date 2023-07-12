docker network create kong-net

docker-compose -f Kong-Konga/docker-compose.yml up -d --build

docker-compose -f Services/docker-compose.yml up -d --build