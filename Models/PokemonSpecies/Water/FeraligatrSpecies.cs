using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Feraligatr Species to store common natural stats of all Feraligatrs
	#region FeraligatrSpecies
	public class FeraligatrSpecies : PokemonSpecies
	{
#nullable enable
		private static FeraligatrSpecies? _instance = null;
#nullable restore
        public static FeraligatrSpecies Instance => _instance ?? (_instance = new FeraligatrSpecies());

		#region FeraligatrSpecies Constructor
		public FeraligatrSpecies() : base(
			160,
			"Feraligatr",
			Water.Instance,
			2.3,
			88.8,
			new PokemonStats(
				85, // HPs
				105, 100, // Attack & Defense
				79, 83, // Spacial Attack & Defense
				78 // Speed
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
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
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
				"Outrage",
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
				"Hydro-Cannon",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Ice-Fang",
				"Rock-Climb",
				"Captivate",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Scald",
				"Water-Pledge",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}