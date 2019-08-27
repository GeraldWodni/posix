# Forth Posix C-Interface

Constants, structures and function footprints are extracted from posix header files.
This is done by using SWIG with the [Forth-Extension](https://github.com/GeraldWodni/swig).

## Usage
Just include the required file from your system:
`dist/<forth-system>/.*/<c-name>.<extension>`

i.e.: `dist/gforth/stdio.fs`

## Hints
Common gcc-attributes that break swig are defined in `fixgcc.ih`
The extension `.ih` means interface-header, as `.i` would interfere with make's magic

## ToDo:
### standard way to include
should always be includeable like one of the following:
- `include c/stdio.4th`
- `cinclude stdio.4th`
- `cinclude sys/time.4th`
- `#include stdio`
- `#include stdio.4th`
- `#include stdio.h`

### structure
`dist/<forth-system>/<architecture>/.*<c-name>.<extension>`

### add-lib
- check which and if add-lib is required

### regex.h, sys/socket.h
Includes bitfields in structs. These fail compilation when offsetof is used on them.

### trace.h
Where is this file in a strandard GNU distro?
