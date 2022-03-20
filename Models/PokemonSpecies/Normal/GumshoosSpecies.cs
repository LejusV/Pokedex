using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gumshoos Species to store common natural stats of all Gumshooss
	#region GumshoosSpecies
	public class GumshoosSpecies : PokemonSpecies
	{
#nullable enable
		private static GumshoosSpecies? _instance = null;
#nullable restore
        public static GumshoosSpecies Instance => _instance ?? (_instance = new GumshoosSpecies());

		#region GumshoosSpecies Constructor
		public GumshoosSpecies() : base(
			735,
			"Gumshoos",
			Normal.Instance,
			0.7,
			14.2,
			new PokemonStats(
				88, // HPs
				110, 60, // Attack & Defense
				55, 60, // Spacial Attack & Defense
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
				"Sand-Attack",
				"Tackle",
				"Take-Down",
				"Thrash",
				"Leer",
				"Bite",
				"Roar",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Crunch",
				"Torment",
				"Facade",
				"Taunt",
				"Yawn",
				"Odor-Sleuth",
				"Rock-Tomb",
				"U-Turn",
				"Payback",
				"Fling",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}