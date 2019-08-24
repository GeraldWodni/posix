SWIG       = swig
OUTPUT     = aio
INTERFACE  = $(OUTPUT).i
OPTIONS    = -forth -stackcomments -use-structs -I/usr/include -I/usr/lib/gcc/x86_64-linux-gnu/4.9/include/

$(OUTPUT).fs: $(OUTPUT).fsx
	./$(OUTPUT).fsx -gforth > $(OUTPUT).fs

$(OUTPUT).fsx: $(OUTPUT).fsi
	$(CC) -o $(OUTPUT).fsx $(OUTPUT)-fsi.c

$(OUTPUT).fsi:
	$(SWIG) $(OPTIONS) -o $(OUTPUT)-fsi.c $(INTERFACE)

.PHONY: clean

clean:
	rm -f $(OUTPUT)-fsi.c
	rm -f $(OUTPUT).fs
	rm -f $(OUTPUT).fsx
