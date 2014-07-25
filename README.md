HelloWorldOwinHost
==================
Example of OWIN with Mono and Owinhost.exe

Note
----
The code is required a specific structure. When you build the code, you need to
move the assembly from `./bin/Debug` to `./bin`.

The code is provided with two types of configurations. You can find the setting
from `web.config` file like below:

- `DevelopmentConfiguration`
- `ProductionConfiguration`

How to execute
--------------
Do build the code in Xamarin first. You can get the assembly files in your `bin/Debug`.

    $ cd HelloWorldOwinHost
    $ mv bin/Debug/* bin
    $ mono ../packages/OwinHost.<Version>/tools/OwinHost.exe DevelopmentConfiguration

Then, you can access the OWIN on the web browser.

