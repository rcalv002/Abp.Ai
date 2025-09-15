#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 341ab61c-fae6-4baf-9e07-8a551e53de4f -t
    fi
    cd ../
fi

docker-compose up -d
