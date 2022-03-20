using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Comfey Species to store common natural stats of all Comfeys
	#region ComfeySpecies
	public class ComfeySpecies : PokemonSpecies
	{
#nullable enable
		private static ComfeySpecies? _instance = null;
#nullable restore
        public static ComfeySpecies Instance => _instance ?? (_instance = new ComfeySpecies());

		#region ComfeySpecies Constructor
		public ComfeySpecies() : base(
			764,
			"Comfey",
			Fairy.Instance,
			0.1,
			0.3,
			new PokemonStats(
				51, // HPs
				52, 90, // Attack & Defense
				82, 110, // Spacial Attack & Defense
				100 // Speed
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
				"Vine-Whip",
				"Wrap",
				"Hyper-Beam",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Amnesia",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Sweet-Kiss",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Aromatherapy",
				"Magical-Leaf",
				"Calm-Mind",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Lucky-Chant",
				"Energy-Ball",
				"Trick-Room",
				"Grass-Knot",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Acrobatics",
				"Petal-Blizzard",
				"Draining-Kiss",
				"Flower-Shield",
				"Grassy-Terrain",
				"Play-Rough",
				"Confide",
				"Dazzling-Gleam",
				"Floral-Healing"
			};
		}
		#endregion
	}
	#endregion
}