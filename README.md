# rof_addons_build
Build script for rof_addons (https://github.com/republic-of-folk/rof_addons)

Uses swiftPbo as submodule. After cloning, you might have to run
  
    git submodule update --remote

Script looks for all folders in the directory that don't start with "@" character and tries to build them into @rof_addons\addons folder