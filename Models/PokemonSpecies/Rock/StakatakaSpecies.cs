using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Stakataka Species to store common natural stats of all Stakatakas
	#region StakatakaSpecies
	public class StakatakaSpecies : PokemonSpecies
	{
#nullable enable
		private static StakatakaSpecies? _instance = null;
#nullable restore
        public static StakatakaSpecies Instance => _instance ?? (_instance = new StakatakaSpecies());

		#region StakatakaSpecies Constructor
		public StakatakaSpecies() : base(
			805,
			"Stakataka",
			Rock.Instance, Steel.Instance,
			5.5,
			820.0,
			new PokemonStats(
				61, // HPs
				131, 211, // Attack & Defense
				53, 101, // Spacial Attack & Defense
				13 // Speed
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
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Rock-Throw",
				"Earthquake",
				"Toxic",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Sandstorm",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Facade",
				"Rock-Tomb",
				"Iron-Defense",
				"Rock-Blast",
				"Gyro-Ball",
				"Rock-Polish",
				"Giga-Impact",
				"Flash-Cannon",
				"Trick-Room",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Wide-Guard",
				"Autotomize",
				"Smack-Down",
				"Round",
				"Bulldoze",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}