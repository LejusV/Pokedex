using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kricketot Species to store common natural stats of all Kricketots
	#region KricketotSpecies
	public class KricketotSpecies : PokemonSpecies
	{
#nullable enable
		private static KricketotSpecies? _instance = null;
#nullable restore
        public static KricketotSpecies Instance => _instance ?? (_instance = new KricketotSpecies());

		#region KricketotSpecies Constructor
		public KricketotSpecies() : base(
			401,
			"Kricketot",
			Bug.Instance,
			0.3,
			2.2,
			new PokemonStats(
				37, // HPs
				25, 41, // Attack & Defense
				25, 41, // Spacial Attack & Defense
				25 // Speed
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
				"Growl",
				"String-Shot",
				"Bide",
				"Snore",
				"Mud-Slap",
				"Uproar",
				"Endeavor",
				"Bug-Bite",
				"Struggle-Bug"
			};
		}
		#endregion
	}
	#endregion
}