using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Nihilego Species to store common natural stats of all Nihilegos
	#region NihilegoSpecies
	public class NihilegoSpecies : PokemonSpecies
	{
#nullable enable
		private static NihilegoSpecies? _instance = null;
#nullable restore
        public static NihilegoSpecies Instance => _instance ?? (_instance = new NihilegoSpecies());

		#region NihilegoSpecies Constructor
		public NihilegoSpecies() : base(
			793,
			"Nihilego",
			Rock.Instance, Poison.Instance,
			1.2,
			55.5,
			new PokemonStats(
				109, // HPs
				53, 47, // Attack & Defense
				127, 131, // Spacial Attack & Defense
				103 // Speed
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
				"Pound",
				"Headbutt",
				"Acid",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Constrict",
				"Psywave",
				"Rest",
				"Substitute",
				"Protect",
				"Sludge-Bomb",
				"Sandstorm",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Mirror-Coat",
				"Facade",
				"Tickle",
				"Toxic-Spikes",
				"Poison-Jab",
				"Power-Gem",
				"Trick-Room",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Head-Smash",
				"Guard-Split",
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Echoed-Voice",
				"Clear-Smog",
				"Confide",
				"Venom-Drench",
				"Dazzling-Gleam",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}