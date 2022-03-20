using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Steenee Species to store common natural stats of all Steenees
	#region SteeneeSpecies
	public class SteeneeSpecies : PokemonSpecies
	{
#nullable enable
		private static SteeneeSpecies? _instance = null;
#nullable restore
        public static SteeneeSpecies Instance => _instance ?? (_instance = new SteeneeSpecies());

		#region SteeneeSpecies Constructor
		public SteeneeSpecies() : base(
			762,
			"Steenee",
			Grass.Instance,
			0.7,
			8.2,
			new PokemonStats(
				52, // HPs
				40, 48, // Attack & Defense
				40, 48, // Spacial Attack & Defense
				62 // Speed
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
				"Double-Slap",
				"Stomp",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Splash",
				"Rest",
				"Substitute",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Rapid-Spin",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Teeter-Dance",
				"Aromatherapy",
				"Magical-Leaf",
				"Payback",
				"Fling",
				"Energy-Ball",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Low-Sweep",
				"Round",
				"Play-Nice",
				"Confide",
				"Aromatic-Mist",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}