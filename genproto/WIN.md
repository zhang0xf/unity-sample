# protobuf-unity-windows

Unity protobuf demo on WIN

## Version

* protoc-3.17.3-win32.zip
* protobuf-csharp-3.17.3.tar.gz

## Build `DLL` for unity on WIN

* download source `protobuf-csharp-3.17.3.tar.gz`
* use visual studio open `\protobuf-3.17.3\csharp\src\Google.Protobuf.sln`
* set Google.Protobuf as default and build `DLL`
![image_text](https://github.com/zhang0xf/unitydemo/blob/main/genproto/image/image1.png)
![image_text](https://github.com/zhang0xf/unitydemo/blob/main/genproto/image/image2.PNG)
* all files in `\protobuf-3.17.3\csharp\src\Google.Protobuf\bin\Release\net45` are needed, copy them to `Assets/Plugins`.
![image_text](https://github.com/zhang0xf/unitydemo/blob/main/genproto/image/image3.PNG)

## Use protoc to compile .proto files

* download release `protoc-3.17.3-win32.zip`
* set $PATH.
* `make`

# Reference

* [Unity C# 编译集成 Google Protobuf](https://john.js.org/2020/11/17/CSharp-Compile-With-Google-Protobuf/)
* [Protocol Buffer Basics: C#](https://developers.google.com/protocol-buffers/docs/csharptutorial)
* [addressbook.proto](https://github.com/protocolbuffers/protobuf/blob/master/examples/addressbook.proto)
* [Protocol Buffers v3.17.3](https://github.com/protocolbuffers/protobuf/releases/tag/v3.17.3)
* [C# Generated Code](https://developers.google.com/protocol-buffers/docs/reference/csharp-generated)
* [C# README.md](https://github.com/protocolbuffers/protobuf/tree/master/csharp)
