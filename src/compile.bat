@echo off
java -jar Tangara.jar %1.mino -platform java -type Class
TokensBuilder.exe %1.tokens
ildasm %1.exe