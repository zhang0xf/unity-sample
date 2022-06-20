set PROTO_DIR=./proto
set CPP_OUT=../sample/Assets/Nw/Scripts/Protobuf

protoc.exe --version

protoc.exe -I=%PROTO_DIR% --csharp_out=%CPP_OUT% %PROTO_DIR%/addressbook.proto
protoc.exe -I=%PROTO_DIR% --csharp_out=%CPP_OUT% %PROTO_DIR%/message.proto

pause
 