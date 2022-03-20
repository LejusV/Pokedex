using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Umbreon Species to store common natural stats of all Umbreons
	#region UmbreonSpecies
	public class UmbreonSpecies : PokemonSpecies
	{
#nullable enable
		private static UmbreonSpecies? _instance = null;
#nullable restore
        public static UmbreonSpecies Instance => _instance ?? (_instance = new UmbreonSpecies());

		#region UmbreonSpecies Constructor
		public UmbreonSpecies() : base(
			197,
			"Umbreon",
			Dark.Instance,
			1.0,
			27.0,
			new PokemonStats(
				95, // HPs
				65, 110, // Attack & Defense
				60, 130, // Spacial Attack & Defense
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
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Hyper-Beam",
				"Dig",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Torment",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Covet",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Guard-Swap",
				"Last-Resort",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
				"Captivate",
				"Wonder-Room",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Snarl",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}