﻿## Integrating AdminLTE 
	1. Download the latest version AdminLTE 3.0.5 source code zip file.
		https://github.com/ColorlibHQ/AdminLTE/releases
	2. Now copy & paste the css, img, js folder’s file into the 
		\wwwroot\ folder in your project from your 
		\AdminLTE-3.0.5\dist location.


## AdminLTE V3.0.5 Template Folder Structure

dist/ – This is the distribution folder that contains all the css and js files, 
		mostly all the static files of the application. 
		We will need to copy this folder over to the www-root folder in our MVC Project later on.

pages/ – Here you get a list of all pre-made HTML files to refer to. 
		This is quite an important section as it uses all the available components 
		and can be helpful to check out how components are being utilized.

plugins/ – 3rd party JS plugins 
			like select2, jquery, data tables, etc are contained here. 
			We will need this folder too.

starter.html – Here we get a minimal setup of the HTML file. 
			We will be using this page to generate the _Layout.cshml for our ASP.NET Core MVC Application. I have attached a screenshot below.
