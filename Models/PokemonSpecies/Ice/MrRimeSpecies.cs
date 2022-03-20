using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mr-Rime Species to store common natural stats of all Mr-Rimes
	#region Mr-RimeSpecies
	public class MrRimeSpecies : PokemonSpecies
	{
#nullable enable
		private static MrRimeSpecies? _instance = null;
#nullable restore
        public static MrRimeSpecies Instance => _instance ?? (_instance = new MrRimeSpecies());

		#region Mr-RimeSpecies Constructor
		public MrRimeSpecies() : base(
			866,
			"Mr-Rime",
			Ice.Instance, Psychic.Instance,
			1.5,
			58.2,
			new PokemonStats(
				80, // HPs
				85, 75, // Attack & Defense
				110, 100, // Spacial Attack & Defense
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
				
			};
		}
		#endregion
	}
	#endregion
}