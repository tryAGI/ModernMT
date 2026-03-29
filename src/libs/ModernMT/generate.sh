#!/usr/bin/env bash
set -euo pipefail
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
# Spec is manually maintained in openapi.yaml (no public spec exists)
autosdk generate openapi.yaml \
  --namespace ModernMT \
  --clientClassName ModernMTClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
