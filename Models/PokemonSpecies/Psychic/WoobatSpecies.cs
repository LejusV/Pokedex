using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Woobat Species to store common natural stats of all Woobats
	#region WoobatSpecies
	public class WoobatSpecies : PokemonSpecies
	{
#nullable enable
		private static WoobatSpecies? _instance = null;
#nullable restore
        public static WoobatSpecies Instance => _instance ?? (_instance = new WoobatSpecies());

		#region WoobatSpecies Constructor
		public WoobatSpecies() : base(
			527,
			"Woobat",
			Psychic.Instance, Flying.Instance,
			0.4,
			2.1,
			new PokemonStats(
				65, // HPs
				45, 43, // Attack & Defense
				55, 43, // Spacial Attack & Defense
				72 // Speed
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
				"Supersonic",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Charm",
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
				"Flatter",
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
				"Fake-Tears",
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
				"Psycho-Shift",
				"Air-Slash",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Synchronoise",
				"After-You",
				"Round",
				"Stored-Power",
				"Acrobatics",
				"Heart-Stamp",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion
}