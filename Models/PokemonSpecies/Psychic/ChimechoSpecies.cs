using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Chimecho Species to store common natural stats of all Chimechos
	#region ChimechoSpecies
	public class ChimechoSpecies : PokemonSpecies
	{
#nullable enable
		private static ChimechoSpecies? _instance = null;
#nullable restore
        public static ChimechoSpecies Instance => _instance ?? (_instance = new ChimechoSpecies());

		#region ChimechoSpecies Constructor
		public ChimechoSpecies() : base(
			358,
			"Chimecho",
			Psychic.Instance,
			0.6,
			1.0,
			new PokemonStats(
				75, // HPs
				50, 80, // Attack & Defense
				95, 90, // Spacial Attack & Defense
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
				"Bind",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Disable",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Mimic",
				"Double-Team",
				"Recover",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Perish-Song",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Yawn",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Cosmic-Power",
				"Signal-Beam",
				"Extrasensory",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Healing-Wish",
				"Natural-Gift",
				"Last-Resort",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Heal-Pulse",
				"Crafty-Shield",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}