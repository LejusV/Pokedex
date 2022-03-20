using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rockruff Species to store common natural stats of all Rockruffs
	#region RockruffSpecies
	public class RockruffSpecies : PokemonSpecies
	{
#nullable enable
		private static RockruffSpecies? _instance = null;
#nullable restore
        public static RockruffSpecies Instance => _instance ?? (_instance = new RockruffSpecies());

		#region RockruffSpecies Constructor
		public RockruffSpecies() : base(
			744,
			"Rockruff",
			Rock.Instance,
			0.5,
			9.2,
			new PokemonStats(
				45, // HPs
				65, 40, // Attack & Defense
				30, 40, // Spacial Attack & Defense
				60 // Speed
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
				"Thrash",
				"Leer",
				"Bite",
				"Roar",
				"Rock-Throw",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Crunch",
				"Facade",
				"Taunt",
				"Crush-Claw",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Howl",
				"Sucker-Punch",
				"Rock-Polish",
				"Thunder-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Stone-Edge",
				"Stealth-Rock",
				"Round",
				"Echoed-Voice",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}