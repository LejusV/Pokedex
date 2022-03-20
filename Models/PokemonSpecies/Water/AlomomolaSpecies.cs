using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Alomomola Species to store common natural stats of all Alomomolas
	#region AlomomolaSpecies
	public class AlomomolaSpecies : PokemonSpecies
	{
#nullable enable
		private static AlomomolaSpecies? _instance = null;
#nullable restore
        public static AlomomolaSpecies Instance => _instance ?? (_instance = new AlomomolaSpecies());

		#region AlomomolaSpecies Constructor
		public AlomomolaSpecies() : base(
			594,
			"Alomomola",
			Water.Instance,
			1.2,
			31.6,
			new PokemonStats(
				165, // HPs
				75, 80, // Attack & Defense
				40, 45, // Spacial Attack & Defense
				65 // Speed
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
				"Double-Slap",
				"Mist",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Waterfall",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Psych-Up",
				"Shadow-Ball",
				"Whirlpool",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Wish",
				"Magic-Coat",
				"Knock-Off",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Tickle",
				"Bounce",
				"Water-Sport",
				"Calm-Mind",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Healing-Wish",
				"Brine",
				"Aqua-Ring",
				"Aqua-Jet",
				"Wide-Guard",
				"Soak",
				"Round",
				"Scald",
				"Heal-Pulse",
				"Play-Nice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}