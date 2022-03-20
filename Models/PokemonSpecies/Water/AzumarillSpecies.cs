using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Azumarill Species to store common natural stats of all Azumarills
	#region AzumarillSpecies
	public class AzumarillSpecies : PokemonSpecies
	{
#nullable enable
		private static AzumarillSpecies? _instance = null;
#nullable restore
        public static AzumarillSpecies Instance => _instance ?? (_instance = new AzumarillSpecies());

		#region AzumarillSpecies Constructor
		public AzumarillSpecies() : base(
			184,
			"Azumarill",
			Water.Instance, Fairy.Instance,
			0.8,
			28.5,
			new PokemonStats(
				100, // HPs
				50, 80, // Attack & Defense
				60, 80, // Spacial Attack & Defense
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
				"Mega-Punch",
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Waterfall",
				"Swift",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Bounce",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Ring",
				"Aqua-Tail",
				"Focus-Blast",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Scald",
				"Bulldoze",
				"Work-Up",
				"Play-Rough",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}