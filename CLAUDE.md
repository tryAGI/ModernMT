# CLAUDE.md — ModernMT SDK

## Overview

Auto-generated C# SDK for [ModernMT](https://www.modernmt.com/) — adaptive machine translation with translation memories, glossaries, and quality estimation across 200+ languages.
OpenAPI spec manually created from modernmt.com/api docs (no public spec exists).

## Build & Test

```bash
dotnet build ModernMT.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth via `MMT-ApiKey` header (native via `--security-scheme`):

```csharp
var client = new ModernMTClient(apiKey); // MODERNMT_API_KEY env var
```

## Key Files

- `src/libs/ModernMT/openapi.yaml` — Manually created OpenAPI 3.0.3 spec
- `src/libs/ModernMT/generate.sh` — Runs autosdk generate on local spec
- `src/libs/ModernMT/Generated/` — **Never edit** — auto-generated code
- `src/libs/ModernMT/Extensions/ModernMTClient.Tools.cs` — MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` — Example tests

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsTranslateTool()` — Translate text between languages with adaptive translation
- `AsListLanguagesTool()` — List supported language codes
- `AsListMemoriesTool()` — List translation memories
- `AsDetectLanguageTool()` — Detect language of text

## API Coverage

- **Translation**: translate, batch translate, detect language, quality estimation
- **Context Vectors**: generate context vectors for adaptive translation
- **Memories**: CRUD for translation memories
- **Content**: add sentence pairs, TMX files to memories
- **Glossaries**: add glossary terms to memories
- **Import Jobs**: track import progress

## Spec Notes

- Base URL: `https://api.modernmt.com`
- Auth: `MMT-ApiKey` header — native via `--security-scheme ApiKey:Header:MMT-ApiKey`
- Manual spec (no public OpenAPI spec exists)
