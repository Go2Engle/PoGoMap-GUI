@echo off

python -c "print open('config.ini.example').read().replace('#gmaps-key:','gmaps-key:%1')" > config.ini

