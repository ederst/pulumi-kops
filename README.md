# kOps Resource Provider

The kOps Resource Provider lets you manage [kOps](https://kops.sigs.k8s.io) resources.

## Installing

This package is available for several languages/platforms:

### Node.js (JavaScript/TypeScript)

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

```bash
npm install @pulumi/kops
```

or `yarn`:

```bash
yarn add @pulumi/kops
```

### Python

To use from Python, install using `pip`:

```bash
pip install pulumi_kops
```

### Go

To use from Go, use `go get` to grab the latest version of the library:

```bash
go get github.com/ederst/pulumi-kops/sdk/go/...
```

### .NET

To use from .NET, install using `dotnet add package`:

```bash
dotnet add package Pulumi.Kops
```

## Configuration

The following configuration points are available for the `kops` provider:

<!-- TODO: tbd -->
- `kops:apiKey` (environment: `KOPS_API_KEY`) - the API key for `kops`
- `kops:region` (environment: `KOPS_REGION`) - the region in which to deploy resources

## Reference

For detailed reference documentation, please visit [the Pulumi registry](https://www.pulumi.com/registry/packages/kops/api-docs/).
