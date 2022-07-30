WORKDIR = .

PROTO_DIR=$(WORKDIR)/proto
CPP_OUT=$(WORKDIR)/demo/Assets/Nw/Scripts/Pb

default: all

all: pb

pb:
	@protoc -I=$(PROTO_DIR) --csharp_out=$(CPP_OUT) $(PROTO_DIR)/addressbook.proto
	@protoc -I=$(PROTO_DIR) --csharp_out=$(CPP_OUT) $(PROTO_DIR)/msg.proto