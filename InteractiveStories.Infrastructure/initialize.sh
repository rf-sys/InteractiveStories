until dotnet ef database update; do
>&2 echo "PostgreSQL is starting up"
sleep 1
done