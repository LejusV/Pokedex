using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Golisopod Species to store common natural stats of all Golisopods
	#region GolisopodSpecies
	public class GolisopodSpecies : PokemonSpecies
	{
#nullable enable
		private static GolisopodSpecies? _instance = null;
#nullable restore
        public static GolisopodSpecies Instance => _instance ?? (_instance = new GolisopodSpecies());

		#region GolisopodSpecies Constructor
		public GolisopodSpecies() : base(
			768,
			"Golisopod",
			Bug.Instance, Water.Instance,
			2.0,
			108.0,
			new PokemonStats(
				75, // HPs
				125, 140, // Attack & Defense
				60, 90, // Spacial Attack & Defense
				40 // Speed
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
				"Swords-Dance",
				"Sand-Attack",
				"Pin-Missile",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Leech-Life",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Bulk-Up",
				"Payback",
				"Fling",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Bug-Bite",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Struggle-Bug",
				"Frost-Breath",
				"Razor-Shell",
				"Snarl",
				"Confide",
				"First-Impression",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion
}