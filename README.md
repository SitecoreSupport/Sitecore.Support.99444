# Sitecore.Support.99444
Configuring a proxy server for requests to the geolocation services is impossible

## Main

This repository contains Sitecore Patch #99444, which adds a possibility to configure a proxy server to for the Sitecore Geolocation IP requests

## Deployment

To apply the patch perform the following steps on both CM and CD servers:

1. Place the `Sitecore.Support.99444.dll` assembly into the `\bin` directory.
2. Place the `Sitecore.Support.99444.config` file into the `\App_Config\Include\CES` folder. 

## Content 

Sitecore Patch includes the following files:

1. `\bin\Sitecore.Support.99444.dll`
2. `\App_Config\Include\CES\Sitecore.Support.99444.config`
