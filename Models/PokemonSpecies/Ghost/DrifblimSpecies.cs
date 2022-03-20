using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Drifblim Species to store common natural stats of all Drifblims
	#region DrifblimSpecies
	public class DrifblimSpecies : PokemonSpecies
	{
#nullable enable
		private static DrifblimSpecies? _instance = null;
#nullable restore
        public static DrifblimSpecies Instance => _instance ?? (_instance = new DrifblimSpecies());

		#region DrifblimSpecies Constructor
		public DrifblimSpecies() : base(
			426,
			"Drifblim",
			Ghost.Instance, Flying.Instance,
			1.2,
			15.0,
			new PokemonStats(
				150, // HPs
				80, 44, // Attack & Defense
				90, 54, // Spacial Attack & Defense
				80 // Speed
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
				"Fly",
				"Bind",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Minimize",
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
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Knock-Off",
				"Skill-Swap",
				"Secret-Power",
				"Astonish",
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
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Telekinesis",
				"Round",
				"Hex",
				"Acrobatics",
				"Phantom-Force",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}