Il2CppDumper + dnSpy Setup for Finding Exact Offsets

1. Pull VRFS APK using SideQuest or ADB.
2. Download Il2CppDumper (latest release).
3. Run Il2CppDumper on the APK and global-metadata.dat.
4. It generates DummyDll folder with decompiled assemblies.
5. Open the main assembly in dnSpy.
6. Search for classes containing:
   - Ball, Football, Rigidbody
   - Player, CharacterController, Movement
   - Kick, Shoot, Force
   - Prefab, Instantiate, Network
7. Note the exact method names for kicking, player movement, ball instantiation, and network events.
8. Update the patches in the mod code with the real method names.

This is required to make Super Kicks, Fly, Noclip, and Gun work perfectly instead of using placeholders.