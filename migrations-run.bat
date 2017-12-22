echo off

cd .\HomeExpenses.Infrastructure\

echo Migration: Bill

dotnet ef database update

echo on