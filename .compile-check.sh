#!/usr/bin/env bash
# Offline signature check of Assets/Scripts/Generated against Unity's managed
# assemblies + the ugui/TMP source + DOTween. No Unity Editor is launched.
set -u
P="/c/AndroidWorkspace/projects/JokirJewelsGrid"
U="/c/Program Files/Unity/Hub/Editor/6000.5.10f1/Editor/Data"
DN="/c/AndroidWorkspace/tools/dotnet/dotnet.exe"
CSC="$(ls -d /c/AndroidWorkspace/tools/dotnet/sdk/*/Roslyn/bincore/csc.dll | head -1)"
REF="$(ls -d /c/AndroidWorkspace/tools/dotnet/packs/Microsoft.NETCore.App.Ref/*/ref/net8.0 2>/dev/null | head -1)"
OUT="$P/.compile-check.rsp"
: > "$OUT"

echo "-nostdlib" >> "$OUT"
echo "-target:library" >> "$OUT"
echo "-nowarn:CS0169,CS0414,CS0649,CS1701,CS1702" >> "$OUT"
echo "-out:$(cygpath -m "$P")/.compile-check.dll" >> "$OUT"

for d in "$REF"/*.dll; do echo "-r:\"$(cygpath -m "$d")\""; done >> "$OUT"
# Unity runtime assemblies, skipping anything whose BASENAME starts with UnityEditor
for d in "$U/Managed/UnityEngine/"*.dll; do
  b="$(basename "$d")"
  case "$b" in UnityEditor*) continue;; esac
  echo "-r:\"$(cygpath -m "$d")\""
done >> "$OUT"
echo "-r:\"$(cygpath -m "$P/Assets/Plugins/Demigiant/DOTween/DOTween.dll")\"" >> "$OUT"

# ugui + TMP source
find "$U/Resources/PackageManager/BuiltInPackages/com.unity.ugui/Runtime" -name '*.cs' \
  | while read -r f; do echo "\"$(cygpath -m "$f")\""; done >> "$OUT"
# DOTween module sources shipped in the project
find "$P/Assets/Plugins/Demigiant/DOTween/Modules" -name '*.cs' 2>/dev/null \
  | while read -r f; do echo "\"$(cygpath -m "$f")\""; done >> "$OUT"
# the template's own scripts + ours (template types are referenced by generated code)
find "$P/Assets/Scripts" -name '*.cs' \
  | while read -r f; do echo "\"$(cygpath -m "$f")\""; done >> "$OUT"

"$DN" "$CSC" "@$(cygpath -m "$OUT")" 2>&1 | grep -E "error CS" > "$P/.compile-check.log"
echo "=== errors under Assets/Scripts/Generated ==="
grep -F "Scripts\\Generated" "$P/.compile-check.log" | head -60
echo "=== total errors: $(wc -l < "$P/.compile-check.log") (generated: $(grep -cF 'Scripts\Generated' "$P/.compile-check.log")) ==="
