docker build -t demomvc .
docker run -d -p 8080:80 --name myapp demomvc
docker stop myapp
docker rm myapp

docker cp migration.sql myapp:/app/.

docker exec -it myapp sh

sqlite3 MvcMovie.db

docker exec -it myapp /bin/bash
docker logs myapp --tail 50 -f


dotnet aspnet-codegenerator controller -name MoviesController -m Movie -dc MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries 

dotnet ef migrations add InitialCreate
dotnet ef database update
