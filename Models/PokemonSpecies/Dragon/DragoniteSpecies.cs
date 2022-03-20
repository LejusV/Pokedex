using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dragonite Species to store common natural stats of all Dragonites
	#region DragoniteSpecies
	public class DragoniteSpecies : PokemonSpecies
	{
#nullable enable
		private static DragoniteSpecies? _instance = null;
#nullable restore
        public static DragoniteSpecies Instance => _instance ?? (_instance = new DragoniteSpecies());

		#region DragoniteSpecies Constructor
		public DragoniteSpecies() : base(
			149,
			"Dragonite",
			Dragon.Instance, Flying.Instance,
			2.2,
			210.0,
			new PokemonStats(
				91, // HPs
				134, 95, // Attack & Defense
				100, 100, // Spacial Attack & Defense
				80 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Razor-Wind",
				"Cut",
				"Wing-Attack",
				"Fly",
				"Bind",
				"Slam",
				"Headbutt",
				"Horn-Drill",
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Roar",
				"Flamethrower",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Whirlpool",
				"Heat-Wave",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Air-Cutter",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Fling",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Focus-Blast",
				"Giga-Impact",
				"Defog",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Ominous-Wind",
				"Hone-Claws",
				"Round",
				"Sky-Drop",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Hurricane",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}