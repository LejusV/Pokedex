using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Beartic Species to store common natural stats of all Beartics
	#region BearticSpecies
	public class BearticSpecies : PokemonSpecies
	{
#nullable enable
		private static BearticSpecies? _instance = null;
#nullable restore
        public static BearticSpecies Instance => _instance ?? (_instance = new BearticSpecies());

		#region BearticSpecies Constructor
		public BearticSpecies() : base(
			614,
			"Beartic",
			Ice.Instance,
			2.6,
			260.0,
			new PokemonStats(
				95, // HPs
				130, 80, // Attack & Defense
				70, 80, // Spacial Attack & Defense
				50 // Speed
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
				"Ice-Punch",
				"Swords-Dance",
				"Cut",
				"Thrash",
				"Growl",
				"Roar",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"Bide",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Flail",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Sheer-Cold",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Water-Pulse",
				"Brine",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Stone-Edge",
				"Grass-Knot",
				"Aqua-Jet",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Frost-Breath",
				"Icicle-Crash",
				"Play-Nice",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}