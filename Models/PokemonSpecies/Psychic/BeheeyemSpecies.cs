using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Beheeyem Species to store common natural stats of all Beheeyems
	#region BeheeyemSpecies
	public class BeheeyemSpecies : PokemonSpecies
	{
#nullable enable
		private static BeheeyemSpecies? _instance = null;
#nullable restore
        public static BeheeyemSpecies Instance => _instance ?? (_instance = new BeheeyemSpecies());

		#region BeheeyemSpecies Constructor
		public BeheeyemSpecies() : base(
			606,
			"Beheeyem",
			Psychic.Instance,
			1.0,
			34.5,
			new PokemonStats(
				75, // HPs
				75, 75, // Attack & Defense
				125, 95, // Spacial Attack & Defense
				40 // Speed
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
				"Headbutt",
				"Growl",
				"Psybeam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Miracle-Eye",
				"Embargo",
				"Heal-Block",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Guard-Split",
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Synchronoise",
				"Simple-Beam",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Ally-Switch",
				"Confide",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion
}