kmon
==========

ASP.NET 5 wrapper for [nodemon](http://nodemon.io/). It will use nodemon to watch your source folder for changes and kill and restart your
web server whenever a change is detected. Main use is when making web apps without Visual Studio and it's design time host. 

## Requirements
Since it uses nodemon to wrap the call to the ASP.NET webserver, both [Node](http://nodejs.org/) and [nodemon](http://nodemon.io/) has to be installed. 

## Add kmon to your web project: 

`kpm install kmon` to install from [Nuget.org](https://www.nuget.org/packages/kmon/)

Add a `mon` command to your project.json file: 

```
"commands": {
    /* Change the port number when you are self hosting this application */
    "web": "Microsoft.AspNet.Hosting --server Microsoft.AspNet.Server.WebListener --server.urls http://localhost:5000",
    "gen": "Microsoft.Framework.CodeGeneration",
    "ef": "EntityFramework.Commands",
    "mon" : "kmon --ext cs,json,js --server web"
},
```
From the command line, run `k mon`. It's pronounced *"kuh-mon"*. 

You can call it something else than `mon`, but then you can't shout out "kuh-mon!" when you run it. 

kmon passes parameters on to nodemon so `--ext cs,json,js` are nodemon parameters telling it to watch files ending in 
one of those extensions. The `--server` parameter is used to specify the necessary hosting client.  Specify `web` for Windows and `kestrel` for OSX, Linux.

If either `--ext` or `--server` is not specified the default are shown above.

## Known issues
This is the first release and a work in progress. Critical issues:
* Little or no error handling. 
* Needs more flexibility in handling cross platform projects 
