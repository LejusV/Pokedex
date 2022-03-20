using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Oranguru Species to store common natural stats of all Orangurus
	#region OranguruSpecies
	public class OranguruSpecies : PokemonSpecies
	{
#nullable enable
		private static OranguruSpecies? _instance = null;
#nullable restore
        public static OranguruSpecies Instance => _instance ?? (_instance = new OranguruSpecies());

		#region OranguruSpecies Constructor
		public OranguruSpecies() : base(
			765,
			"Oranguru",
			Normal.Instance, Psychic.Instance,
			1.5,
			76.0,
			new PokemonStats(
				90, // HPs
				60, 80, // Attack & Defense
				90, 110, // Spacial Attack & Defense
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
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Feint-Attack",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Brick-Break",
				"Extrasensory",
				"Calm-Mind",
				"Payback",
				"Embargo",
				"Fling",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Foul-Play",
				"After-You",
				"Round",
				"Stored-Power",
				"Quash",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Psychic-Terrain",
				"Instruct",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}