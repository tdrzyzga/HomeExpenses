echo off

cd .\HomeExpenses.Domain\

echo Migration: Bill

dotnet ef database update

echo on