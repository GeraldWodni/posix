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
