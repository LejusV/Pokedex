using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mareanie Species to store common natural stats of all Mareanies
	#region MareanieSpecies
	public class MareanieSpecies : PokemonSpecies
	{
#nullable enable
		private static MareanieSpecies? _instance = null;
#nullable restore
        public static MareanieSpecies Instance => _instance ?? (_instance = new MareanieSpecies());

		#region MareanieSpecies Constructor
		public MareanieSpecies() : base(
			747,
			"Mareanie",
			Poison.Instance, Water.Instance,
			0.4,
			8.0,
			new PokemonStats(
				50, // HPs
				53, 62, // Attack & Defense
				43, 52, // Spacial Attack & Defense
				45 // Speed
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
				"Poison-Sting",
				"Pin-Missile",
				"Bite",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Peck",
				"Toxic",
				"Double-Team",
				"Recover",
				"Haze",
				"Spike-Cannon",
				"Rest",
				"Substitute",
				"Protect",
				"Sludge-Bomb",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Hail",
				"Facade",
				"Payback",
				"Toxic-Spikes",
				"Poison-Jab",
				"Wide-Guard",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Frost-Breath",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion
}