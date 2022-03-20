using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Elgyem Species to store common natural stats of all Elgyems
	#region ElgyemSpecies
	public class ElgyemSpecies : PokemonSpecies
	{
#nullable enable
		private static ElgyemSpecies? _instance = null;
#nullable restore
        public static ElgyemSpecies Instance => _instance ?? (_instance = new ElgyemSpecies());

		#region ElgyemSpecies Constructor
		public ElgyemSpecies() : base(
			605,
			"Elgyem",
			Psychic.Instance,
			0.5,
			9.0,
			new PokemonStats(
				55, // HPs
				55, 55, // Attack & Defense
				85, 55, // Spacial Attack & Defense
				30 // Speed
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
				"Disable",
				"Psybeam",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Teleport",
				"Double-Team",
				"Recover",
				"Barrier",
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
				"Astonish",
				"Rock-Tomb",
				"Cosmic-Power",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Miracle-Eye",
				"Embargo",
				"Heal-Block",
				"Power-Swap",
				"Guard-Swap",
				"Dark-Pulse",
				"Energy-Ball",
				"Nasty-Plot",
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
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}