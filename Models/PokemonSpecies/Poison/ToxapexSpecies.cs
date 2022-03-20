using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Toxapex Species to store common natural stats of all Toxapexs
	#region ToxapexSpecies
	public class ToxapexSpecies : PokemonSpecies
	{
#nullable enable
		private static ToxapexSpecies? _instance = null;
#nullable restore
        public static ToxapexSpecies Instance => _instance ?? (_instance = new ToxapexSpecies());

		#region ToxapexSpecies Constructor
		public ToxapexSpecies() : base(
			748,
			"Toxapex",
			Poison.Instance, Water.Instance,
			0.7,
			14.5,
			new PokemonStats(
				50, // HPs
				63, 152, // Attack & Defense
				53, 142, // Spacial Attack & Defense
				35 // Speed
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
				"Light-Screen",
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
				"Hail",
				"Facade",
				"Payback",
				"Toxic-Spikes",
				"Poison-Jab",
				"Wide-Guard",
				"Venoshock",
				"Smack-Down",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Frost-Breath",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Baneful-Bunker",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion
}