using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Meowstic-Male Species to store common natural stats of all Meowstic-Males
	#region Meowstic-MaleSpecies
	public class MeowsticMaleSpecies : PokemonSpecies
	{
#nullable enable
		private static MeowsticMaleSpecies? _instance = null;
#nullable restore
        public static MeowsticMaleSpecies Instance => _instance ?? (_instance = new MeowsticMaleSpecies());

		#region Meowstic-MaleSpecies Constructor
		public MeowsticMaleSpecies() : base(
			678,
			"Meowstic-Male",
			Psychic.Instance,
			0.6,
			8.5,
			new PokemonStats(
				74, // HPs
				48, 76, // Attack & Defense
				83, 81, // Spacial Attack & Defense
				104 // Speed
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
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Charm",
				"Swagger",
				"Mean-Look",
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
				"Shadow-Ball",
				"Fake-Out",
				"Torment",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Miracle-Eye",
				"Payback",
				"Sucker-Punch",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Work-Up",
				"Disarming-Voice",
				"Misty-Terrain",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}