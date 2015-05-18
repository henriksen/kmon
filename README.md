kmon
==========

ASP.NET 5 wrapper for [nodemon](https://github.com/remy/nodemon). It will use nodemon to watch your source folder for changes and kill and restart your
web server, or console application, whenever a change is detected. Main use is when making web apps without Visual Studio and it's design time host. 

## Add kmon to your project: 

`dnu install kmon` to install from Nuget.org

**Prerequisites**
You require [nodemon](https://github.com/remy/nodemon). You can install nodemon using ```npm install nodemon```

Add a `mon` command to your project.json file: 

**Web Project**
```
"commands": {
        "web": "Microsoft.AspNet.Hosting --server Microsoft.AspNet.Server.WebListener --server.urls http://localhost:5000",
        "kestrel": "Microsoft.AspNet.Hosting --server Kestrel --server.urls http://localhost:5001",
        "gen": "Microsoft.Framework.CodeGeneration",
        "mon" : "kmon --ext cs,json,js,cshtml --server kestrel"
},
```

**Command Line Project**
```
"commands": {
    "run": "run",
    "mon" : "kmon --ext cs --server run"
  },
```

From the command line, run `dnx . mon`. It's pronounced *"kuh-mon"*. 

You can call it something else than `mon`, but then you can't shout out "kuh-mon!" when you run it. 

**kmon** passes parameters on to nodemon so `--ext cs,json,js` are nodemon parameters telling it to watch files ending in 
one of those extensions. The `--server` parameter is used to specify the necessary hosting client.  Specify `web` for Windows and `kestrel` for OSX, Linux.

If either `--ext` or `--server` is not specified the default are shown above.

## Known issues
This is the first release and a work in progress. 
* Little or no error handling. 
