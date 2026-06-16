#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated
# Spec is manually maintained in openapi.yaml (no public spec exists)
# Auth: ModernMT uses MMT-ApiKey header.
autosdk generate openapi.yaml \
  --namespace ModernMT \
  --clientClassName ModernMTClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:MMT-ApiKey

rm -rf ../../cli/ModernMT.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/ModernMT.CLI \
  --sdk-project ../../libs/ModernMT/ModernMT.csproj \
  --targetFramework net10.0 \
  --namespace ModernMT \
  --clientClassName ModernMTClient \
  --package-id ModernMT.CLI \
  --tool-command-name modern-mt \
  --user-secrets-id ModernMT.CLI \
  --api-key-env-var MODERNMT_API_KEY \
  --base-url-env-var MODERNMT_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:MMT-ApiKey
