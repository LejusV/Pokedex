using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bounsweet Species to store common natural stats of all Bounsweets
	#region BounsweetSpecies
	public class BounsweetSpecies : PokemonSpecies
	{
#nullable enable
		private static BounsweetSpecies? _instance = null;
#nullable restore
        public static BounsweetSpecies Instance => _instance ?? (_instance = new BounsweetSpecies());

		#region BounsweetSpecies Constructor
		public BounsweetSpecies() : base(
			761,
			"Bounsweet",
			Grass.Instance,
			0.3,
			3.2,
			new PokemonStats(
				42, // HPs
				30, 38, // Attack & Defense
				30, 38, // Spacial Attack & Defense
				32 // Speed
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
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Splash",
				"Rest",
				"Substitute",
				"Flail",
				"Protect",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Rapid-Spin",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Teeter-Dance",
				"Grass-Whistle",
				"Magical-Leaf",
				"Feint",
				"Acupressure",
				"Energy-Ball",
				"Grass-Knot",
				"Round",
				"Play-Rough",
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