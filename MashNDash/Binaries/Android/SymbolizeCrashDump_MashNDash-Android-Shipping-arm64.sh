#!/bin/sh
if [ $? -ne 0]; then
echo "Required argument missing, pass a dump of adb crash log."
exit 1
fi
cd "`dirname "$0"`"
NDKSTACK=
if [ "$ANDROID_NDK_ROOT" != "" ]; then NDKSTACK=$%ANDROID_NDK_ROOT/ndk-stack; else ADB=/ndk-stack; fi
$NDKSTACK -sym MashNDash_Symbols_v44/MashNDasharm64 -dump "%1" > MashNDash_SymbolizedCallStackOutput.txt
exit 0
