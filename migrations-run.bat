echo off

cd .\HomeExpenses.Infrastructure\

echo Migration: Bill

dotnet ef database update -s ..\HomeExpenses.Host\

echo on