using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mudbray Species to store common natural stats of all Mudbrays
	#region MudbraySpecies
	public class MudbraySpecies : PokemonSpecies
	{
#nullable enable
		private static MudbraySpecies? _instance = null;
#nullable restore
        public static MudbraySpecies Instance => _instance ?? (_instance = new MudbraySpecies());

		#region MudbraySpecies Constructor
		public MudbraySpecies() : base(
			749,
			"Mudbray",
			Ground.Instance,
			1.0,
			110.0,
			new PokemonStats(
				70, // HPs
				100, 70, // Attack & Defense
				45, 55, // Spacial Attack & Defense
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
				"Stomp",
				"Double-Kick",
				"Mega-Kick",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Counter",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Hidden-Power",
				"Facade",
				"Superpower",
				"Mud-Sport",
				"Rock-Tomb",
				"Iron-Defense",
				"Close-Combat",
				"Payback",
				"Mud-Bomb",
				"Heavy-Slam",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Rototiller",
				"Confide",
				"High-Horsepower"
			};
		}
		#endregion
	}
	#endregion
}