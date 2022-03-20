using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Celebi Species to store common natural stats of all Celebis
	#region CelebiSpecies
	public class CelebiSpecies : PokemonSpecies
	{
#nullable enable
		private static CelebiSpecies? _instance = null;
#nullable restore
        public static CelebiSpecies Instance => _instance ?? (_instance = new CelebiSpecies());

		#region CelebiSpecies Constructor
		public CelebiSpecies() : base(
			251,
			"Celebi",
			Psychic.Instance, Grass.Instance,
			0.6,
			5.0,
			new PokemonStats(
				100, // HPs
				100, 100, // Attack & Defense
				100, 100, // Spacial Attack & Defense
				100 // Speed
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
				"Swords-Dance",
				"Cut",
				"Double-Edge",
				"Hyper-Beam",
				"Leech-Seed",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Metronome",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Perish-Song",
				"Detect",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Skill-Swap",
				"Secret-Power",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Magical-Leaf",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Healing-Wish",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Heal-Block",
				"Last-Resort",
				"Worry-Seed",
				"Sucker-Punch",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Leaf-Storm",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}