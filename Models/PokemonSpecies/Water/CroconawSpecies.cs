using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Croconaw Species to store common natural stats of all Croconaws
	#region CroconawSpecies
	public class CroconawSpecies : PokemonSpecies
	{
#nullable enable
		private static CroconawSpecies? _instance = null;
#nullable restore
        public static CroconawSpecies Instance => _instance ?? (_instance = new CroconawSpecies());

		#region CroconawSpecies Constructor
		public CroconawSpecies() : base(
			159,
			"Croconaw",
			Water.Instance,
			1.1,
			25.0,
			new PokemonStats(
				65, // HPs
				80, 80, // Attack & Defense
				59, 63, // Spacial Attack & Defense
				58 // Speed
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
				"Mega-Punch",
				"Ice-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Shadow-Claw",
				"Ice-Fang",
				"Captivate",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Scald",
				"Water-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}