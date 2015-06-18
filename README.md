kmon
==========

An ASP.NET 5 command that will run your webserver of choice and restart it when it dies. 

When you run a project command with dnx  (for instance `dnx kestrel`) you can add the `--watch` parameter and `dnx` will watch your directory for changes that require a recompile and kill the command you started. In the example the Kestrel server will quit and have to be restarted again. `kmon` is a utility that will run the dnx command for you and when it quits, kmon will restart it for you. That way you don't have to keep restarting it manually whenever you make code changes. Main use is when making web apps without Visual Studio and it's design time host. 

## Add kmon to your system: 

`dnu commands install kmon 0.5.0-beta` to install from Nuget.org. This will install kmon as a global command and make it available everywhere. 

From the command line, run `kmon` and it will start `dnx . web` as default. You can use the `--server` parameter to specify a different command than web, for instance `kmon --server kestrel` with will run the kestrel command from your project.json.

By the way, it's pronounced *"kuh-mon"*. 


## Known issues
* Little or no error handling. 
