#!/bin/bash
set -e

until PGPASSWORD=$POSTGRES_PASSWORD psql -h postgres -p 5432 -U $POSTGRES_USER -d $POSTGRES_DB -c '\q'; do
  >&2 echo "Waiting PostgreSQL Infra DB..."
  sleep 1
done

>&2 echo "PostgreSQL Infra DB is ready"

dotnet TaskList.Infra.Migrations.dll