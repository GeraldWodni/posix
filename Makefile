# Create Forth-Interface-Sourcecode from C-Headers
# Steps:
# 1. I (SWIG interface file)
# 2. FSI (Resulting C-file containing printfs)
# 3. FSX (Compiled FSI)
# 4. FS (Output after running FSX)

# Swig executable
SWIG       = swig

# swig options
OPTIONS    = -forth -stackcomments -use-structs -I/usr/include

#-- Do not edit below this line --

# Subdirs to search for additional source files
SUBDIRS := $(shell ls -F | grep "\/" )
DIRS := ./ $(SUBDIRS)
INTERFACE_FILES := $(foreach d, $(DIRS), $(wildcard $(d)*.i) )

# Create an FS-Executable file of every i file
FSX_FILES = $(patsubst %.i, %.fsx, $(INTERFACE_FILES))

# FS-Intermediate C-file of every i file
FSI_FILES = $(patsubst %.i, %-fsi.c, $(INTERFACE_FILES))

# Final Forth Files
FS_FILES = $(patsubst %.i, %.fs, $(INTERFACE_FILES))

# Make FS_FILES the default target
all: $(FS_FILES)

# Generate C Interface file 
%-fsi.c: %.i
	$(SWIG) $(OPTIONS) -o $@ $<

# Compile Interface file to FSX
%.fsx: %-fsi.c
	$(CC) -o $@ $<

# Execute and save output
%.fs: %.fsx
	mkdir -p dist/gforth
	./$< -gforth > dist/gforth/$@

# Clean & Debug
.PHONY: makefile-debug
makefile-debug:
	@echo "Interface-Files:$(INTERFACE_FILES)"
	@echo "FSX-Files:$(FSX_FILES)"
	@echo "FSI-Files:$(FSI_FILES)"
	@echo "FS-Files:$(FS_FILES)"

.PHONY: clean
clean:
	rm -f $(FSI_FILES) $(FSI_FILES)

.PHONY: clean-output
depclean:
	rm -f $(FS_FILES)

clean-all: clean clean-output
