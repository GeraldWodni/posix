SWIG       = swig
OUTPUT     = stdlib
INTERFACE  = stdlib.i
OPTIONS    = -forth -stackcomments -use-structs -I/usr/include

$(OUTPUT).fs: $(OUTPUT).fsx
	./$(OUTPUT).fsx -gforth > $(OUTPUT).fs

$(OUTPUT).fsx: $(OUTPUT).fsi
	$(CC) -o $(OUTPUT).fsx $(OUTPUT)-fsi.c

$(OUTPUT).fsi:
	$(SWIG) $(OPTIONS) -o $(OUTPUT)-fsi.c $(INTERFACE)

run: $(OUTPUT).fs
	gforth demo.fs

.PHONY: clean

clean:
	rm -f $(OUTPUT)-fsi.c
	rm -f $(OUTPUT).fs
	rm -f $(OUTPUT).fsx
