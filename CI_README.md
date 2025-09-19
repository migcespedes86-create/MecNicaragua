# CI para generar APK en la nube

## Cómo usar (Debug)
1. Sube este repo a GitHub.
2. Ve a **Actions** → ejecuta el workflow **Build MAUI Android APK (Debug)**.
3. Al terminar, descarga el artefacto **MecNicaMauiLogin-Debug-APK**.

## Cómo usar (Release firmado)
1. Genera un keystore (`.jks`) y convierte a base64.
2. En **Settings → Secrets and variables → Actions → New repository secret** crea:
   - `KEYSTORE_BASE64`: contenido base64 del `.jks`
   - `KEY_ALIAS`: alias de la clave
   - `KEYSTORE_PASSWORD`: password del keystore
   - `KEY_PASSWORD`: password de la clave
3. Ejecuta el workflow **Build MAUI Android APK (Release Signed)** y descarga el artefacto.

> Si prefieres AAB para Play Store, cambia `-p:AndroidPackageFormat=apk` por `aab` en el YAML.
