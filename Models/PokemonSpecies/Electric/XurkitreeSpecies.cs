using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Xurkitree Species to store common natural stats of all Xurkitrees
	#region XurkitreeSpecies
	public class XurkitreeSpecies : PokemonSpecies
	{
#nullable enable
		private static XurkitreeSpecies? _instance = null;
#nullable restore
        public static XurkitreeSpecies Instance => _instance ?? (_instance = new XurkitreeSpecies());

		#region XurkitreeSpecies Constructor
		public XurkitreeSpecies() : base(
			796,
			"Xurkitree",
			Electric.Instance,
			3.8,
			100.0,
			new PokemonStats(
				83, // HPs
				89, 71, // Attack & Defense
				173, 71, // Spacial Attack & Defense
				83 // Speed
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
				"Thunder-Punch",
				"Wrap",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Hypnosis",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Rest",
				"Substitute",
				"Protect",
				"Zap-Cannon",
				"Swagger",
				"Spark",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Charge",
				"Ingrain",
				"Tail-Glow",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Fling",
				"Energy-Ball",
				"Giga-Impact",
				"Discharge",
				"Power-Whip",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Ion-Deluge",
				"Confide",
				"Eerie-Impulse",
				"Electric-Terrain",
				"Dazzling-Gleam",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}