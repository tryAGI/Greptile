dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Greptile \
  --clientClassName GreptileClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
