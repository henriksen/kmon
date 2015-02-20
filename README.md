Kestrelmon
==========

ASP.NET 5 wrapper for [nodemon](https://github.com/remy/nodemon). It will use nodemon to watch your source folder for changes and kill and restart your
web server, or console application, whenever a change is detected. Main use is when making web apps without Visual Studio and it's design time host. 

## Add Kestrelmon to your project: 

`kpm install Kestrelmon` to install from Nuget.org

Add a `mon` command to your project.json file: 

**Web Project**
```
"commands": {
    /* Change the port number when you are self hosting this application */
    "web": "Microsoft.AspNet.Hosting --server Microsoft.AspNet.Server.WebListener --server.urls http://localhost:5000",
    "gen": "Microsoft.Framework.CodeGeneration",
    "ef": "EntityFramework.Commands",
    "mon" : "Kestrelmon --ext cs,json,js --server web"
},
```

**Command Line Project**
```
"commands": {
    "run": "run",
    "mon" : "kmon --ext cs --server run"
  },
```

From the command line, run `k mon`. It's pronounced *"kuh-mon"*. 

You can call it something else than `mon`, but then you can't shout out "kuh-mon!" when you run it. 

Kestrelmon passes parameters on to nodemon so `--ext cs,json,js` are nodemon parameters telling it to watch files ending in 
one of those extensions. The `--server` parameter is used to specify the necessary hosting client.  Specify `web` for Windows and `kestrel` for OSX, Linux.

If either `--ext` or `--server` is not specified the default are shown above.

## Known issues
This is the first release and a work in progress. Critical issues:
* Initial proof of concept only works on Windows and runs the web command. Need some work to run on Mono and run Kestrel. 
* Little or no error handling. 
