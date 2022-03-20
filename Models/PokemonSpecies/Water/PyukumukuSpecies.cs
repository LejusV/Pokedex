using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pyukumuku Species to store common natural stats of all Pyukumukus
	#region PyukumukuSpecies
	public class PyukumukuSpecies : PokemonSpecies
	{
#nullable enable
		private static PyukumukuSpecies? _instance = null;
#nullable restore
        public static PyukumukuSpecies Instance => _instance ?? (_instance = new PyukumukuSpecies());

		#region PyukumukuSpecies Constructor
		public PyukumukuSpecies() : base(
			771,
			"Pyukumuku",
			Water.Instance,
			0.3,
			1.2,
			new PokemonStats(
				55, // HPs
				60, 130, // Attack & Defense
				30, 130, // Spacial Attack & Defense
				5 // Speed
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
				"Toxic",
				"Double-Team",
				"Recover",
				"Harden",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Rest",
				"Substitute",
				"Curse",
				"Spite",
				"Protect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Safeguard",
				"Pain-Split",
				"Baton-Pass",
				"Rain-Dance",
				"Psych-Up",
				"Hail",
				"Memento",
				"Taunt",
				"Helping-Hand",
				"Mud-Sport",
				"Tickle",
				"Water-Sport",
				"Gastro-Acid",
				"Soak",
				"Quash",
				"Bestow",
				"Confide",
				"Venom-Drench",
				"Purify"
			};
		}
		#endregion
	}
	#endregion
}