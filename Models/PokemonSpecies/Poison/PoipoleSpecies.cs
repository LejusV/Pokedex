using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Poipole Species to store common natural stats of all Poipoles
	#region PoipoleSpecies
	public class PoipoleSpecies : PokemonSpecies
	{
#nullable enable
		private static PoipoleSpecies? _instance = null;
#nullable restore
        public static PoipoleSpecies Instance => _instance ?? (_instance = new PoipoleSpecies());

		#region PoipoleSpecies Constructor
		public PoipoleSpecies() : base(
			803,
			"Poipole",
			Poison.Instance,
			0.6,
			1.8,
			new PokemonStats(
				67, // HPs
				73, 67, // Attack & Defense
				73, 67, // Spacial Attack & Defense
				73 // Speed
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
				"Fury-Attack",
				"Growl",
				"Acid",
				"Peck",
				"Toxic",
				"Rest",
				"Substitute",
				"Protect",
				"Sludge-Bomb",
				"Charm",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Facade",
				"Helping-Hand",
				"Poison-Jab",
				"Dragon-Pulse",
				"Nasty-Plot",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Fell-Stinger",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion
}