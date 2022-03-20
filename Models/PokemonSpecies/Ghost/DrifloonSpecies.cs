using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Drifloon Species to store common natural stats of all Drifloons
	#region DrifloonSpecies
	public class DrifloonSpecies : PokemonSpecies
	{
#nullable enable
		private static DrifloonSpecies? _instance = null;
#nullable restore
        public static DrifloonSpecies Instance => _instance ?? (_instance = new DrifloonSpecies());

		#region DrifloonSpecies Constructor
		public DrifloonSpecies() : base(
			425,
			"Drifloon",
			Ghost.Instance, Flying.Instance,
			0.4,
			1.2,
			new PokemonStats(
				90, // HPs
				50, 34, // Attack & Defense
				60, 44, // Spacial Attack & Defense
				70 // Speed
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
				"Gust",
				"Bind",
				"Body-Slam",
				"Disable",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Minimize",
				"Haze",
				"Focus-Energy",
				"Swift",
				"Constrict",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Baton-Pass",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Knock-Off",
				"Skill-Swap",
				"Secret-Power",
				"Astonish",
				"Weather-Ball",
				"Air-Cutter",
				"Silver-Wind",
				"Calm-Mind",
				"Shock-Wave",
				"Gyro-Ball",
				"Natural-Gift",
				"Tailwind",
				"Payback",
				"Embargo",
				"Sucker-Punch",
				"Defog",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Telekinesis",
				"Round",
				"Clear-Smog",
				"Hex",
				"Acrobatics",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}