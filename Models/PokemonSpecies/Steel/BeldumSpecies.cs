using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Beldum Species to store common natural stats of all Beldums
	#region BeldumSpecies
	public class BeldumSpecies : PokemonSpecies
	{
#nullable enable
		private static BeldumSpecies? _instance = null;
#nullable restore
        public static BeldumSpecies Instance => _instance ?? (_instance = new BeldumSpecies());

		#region BeldumSpecies Constructor
		public BeldumSpecies() : base(
			374,
			"Beldum",
			Steel.Instance, Psychic.Instance,
			0.6,
			95.2,
			new PokemonStats(
				40, // HPs
				55, 80, // Attack & Defense
				35, 60, // Spacial Attack & Defense
				30 // Speed
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
				"Headbutt",
				"Take-Down",
				"Iron-Defense",
				"Zen-Headbutt",
				"Iron-Head"
			};
		}
		#endregion
	}
	#endregion
}