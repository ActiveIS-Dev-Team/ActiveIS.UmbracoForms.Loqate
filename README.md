# ActiveIS.UmbracoForms.Loqate

[Loqate](https://www.loqate.com/en-gb/address-verification/) address verification plugin for [Umbraco Forms](https://umbraco.com/products/umbraco-forms/)

## Getting started

This package is supported on Umbraco 8.6+ and Umbraco Forms 8.4.1+.

### Installation

ActiveIS.UmbracoForms.Loqate is available from [Our Umbraco](https://our.umbraco.com/packages/website-utilities/activeisumbracoformsloqate/), [NuGet](https://www.nuget.org/packages/ActiveIS.UmbracoForms.Loqate/) or as a manual download directly from GitHub.

#### Our Umbraco repository
You can find a downloadable package on the [Our Umbraco](https://our.umbraco.com/packages/website-utilities/activeisumbracoformsloqate/) site.

## Usage

This package adds Loqate address verification to Umbraco Forms.

This is tested with **Umbraco V8.6.1** and **Umbraco Forms 8.4.1**

You will need to add the following key to your Web.Config:

    <add key="LoqateKey" value="YOUR SECRET KEY" />
    
For each FieldType to be used with this plugin, `@Model.Alias` needs adding to the FieldType class.

The views can be found in `/Views/Partials/Forms/Themes/[YOURTHEME]/`

### Contribution guidelines

To raise a new bug, create an issue on the GitHub repository. To fix a bug or add new features, fork the repository and send a pull request with your changes. Feel free to add ideas to the repository's issues list if you would to discuss anything related to the package.

## License

Copyright &copy; 2020 [ActiveIS](https://activeis.net) & [Aaron Sadler](https://aaronsadler.uk).

Licensed under the MIT License.
