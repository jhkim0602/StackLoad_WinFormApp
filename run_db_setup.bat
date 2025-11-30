@echo off
chcp 65001
set NLS_LANG=KOREAN_KOREA.AL32UTF8
echo Running stackload_complete.sql with UTF-8 encoding...
sqlplus stackload/1111@xe @stackload_complete.sql
echo Running insert.sql with UTF-8 encoding...
sqlplus stackload/1111@xe @insert.sql
pause
