using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Combee Species to store common natural stats of all Combees
	#region CombeeSpecies
	public class CombeeSpecies : PokemonSpecies
	{
#nullable enable
		private static CombeeSpecies? _instance = null;
#nullable restore
        public static CombeeSpecies Instance => _instance ?? (_instance = new CombeeSpecies());

		#region CombeeSpecies Constructor
		public CombeeSpecies() : base(
			415,
			"Combee",
			Bug.Instance, Flying.Instance,
			0.3,
			5.5,
			new PokemonStats(
				30, // HPs
				30, 42, // Attack & Defense
				30, 42, // Spacial Attack & Defense
				70 // Speed
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
				"Gust",
				"String-Shot",
				"Swift",
				"Snore",
				"Mud-Slap",
				"Sweet-Scent",
				"Endeavor",
				"Air-Cutter",
				"Tailwind",
				"Bug-Buzz",
				"Bug-Bite",
				"Ominous-Wind"
			};
		}
		#endregion
	}
	#endregion
}