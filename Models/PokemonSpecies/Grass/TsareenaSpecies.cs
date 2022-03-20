using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tsareena Species to store common natural stats of all Tsareenas
	#region TsareenaSpecies
	public class TsareenaSpecies : PokemonSpecies
	{
#nullable enable
		private static TsareenaSpecies? _instance = null;
#nullable restore
        public static TsareenaSpecies Instance => _instance ?? (_instance = new TsareenaSpecies());

		#region TsareenaSpecies Constructor
		public TsareenaSpecies() : base(
			763,
			"Tsareena",
			Grass.Instance,
			1.2,
			21.4,
			new PokemonStats(
				72, // HPs
				120, 98, // Attack & Defense
				50, 98, // Spacial Attack & Defense
				72 // Speed
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
				"High-Jump-Kick",
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
				"U-Turn",
				"Payback",
				"Fling",
				"Punishment",
				"Energy-Ball",
				"Giga-Impact",
				"Leaf-Storm",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Low-Sweep",
				"Round",
				"Acrobatics",
				"Confide",
				"Aromatic-Mist",
				"Dazzling-Gleam",
				"Trop-Kick"
			};
		}
		#endregion
	}
	#endregion
}