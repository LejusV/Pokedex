using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Espurr Species to store common natural stats of all Espurrs
	#region EspurrSpecies
	public class EspurrSpecies : PokemonSpecies
	{
#nullable enable
		private static EspurrSpecies? _instance = null;
#nullable restore
        public static EspurrSpecies Instance => _instance ?? (_instance = new EspurrSpecies());

		#region EspurrSpecies Constructor
		public EspurrSpecies() : base(
			677,
			"Espurr",
			Psychic.Instance,
			0.3,
			3.5,
			new PokemonStats(
				62, // HPs
				48, 54, // Attack & Defense
				63, 60, // Spacial Attack & Defense
				68 // Speed
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
				"Scratch",
				"Cut",
				"Leer",
				"Psybeam",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Fake-Out",
				"Torment",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Assist",
				"Magic-Coat",
				"Recycle",
				"Yawn",
				"Snatch",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Payback",
				"Dark-Pulse",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Disarming-Voice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}