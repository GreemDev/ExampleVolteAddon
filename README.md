# ExampleVolteAddon
Example addon for people who don't know the proper structure for Volte addons.

The structure is rather simple. Inside of the `BasicAddon` folder you'll find a `meta.json` file, which contains the addon's name and the description (for uage in the Addon command). The json file does not need to be named `meta.json`; it just needs to have a `.json` file extension.

As for the `logic.cs` file: it can be named anything. It just needs to end with `.cs`. You can do really anything in this file, and there's predetermined variables you have access to as well as an extremely barebones API. You can find what you have access to [here](https://github.com/Ultz/Volte/blob/v3/src/Core/Entities/AddonEnvironment.cs).

If you have any questions, feel free to drop by Volte's [Discord server](discord.gg/H8bcFr2). Note that I will not provide help with *creating* addons; only with structural questions if this didn't explain it well enough.
