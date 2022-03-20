using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wobbuffet Species to store common natural stats of all Wobbuffets
	#region WobbuffetSpecies
	public class WobbuffetSpecies : PokemonSpecies
	{
#nullable enable
		private static WobbuffetSpecies? _instance = null;
#nullable restore
        public static WobbuffetSpecies Instance => _instance ?? (_instance = new WobbuffetSpecies());

		#region WobbuffetSpecies Constructor
		public WobbuffetSpecies() : base(
			202,
			"Wobbuffet",
			Psychic.Instance,
			1.3,
			28.5,
			new PokemonStats(
				190, // HPs
				33, 58, // Attack & Defense
				33, 58, // Spacial Attack & Defense
				33 // Speed
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
				"Counter",
				"Destiny-Bond",
				"Safeguard",
				"Mirror-Coat"
			};
		}
		#endregion
	}
	#endregion
}