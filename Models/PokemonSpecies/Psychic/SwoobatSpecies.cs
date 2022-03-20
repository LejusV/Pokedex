using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Swoobat Species to store common natural stats of all Swoobats
	#region SwoobatSpecies
	public class SwoobatSpecies : PokemonSpecies
	{
#nullable enable
		private static SwoobatSpecies? _instance = null;
#nullable restore
        public static SwoobatSpecies Instance => _instance ?? (_instance = new SwoobatSpecies());

		#region SwoobatSpecies Constructor
		public SwoobatSpecies() : base(
			528,
			"Swoobat",
			Psychic.Instance, Flying.Instance,
			0.9,
			10.5,
			new PokemonStats(
				67, // HPs
				57, 55, // Attack & Defense
				77, 55, // Spacial Attack & Defense
				114 // Speed
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
				"Gust",
				"Fly",
				"Hyper-Beam",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Amnesia",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Knock-Off",
				"Endeavor",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Air-Cutter",
				"Odor-Sleuth",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Roost",
				"Gyro-Ball",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Assurance",
				"Embargo",
				"Air-Slash",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Acrobatics",
				"Heart-Stamp",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}