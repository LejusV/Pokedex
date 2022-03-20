using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gothita Species to store common natural stats of all Gothitas
	#region GothitaSpecies
	public class GothitaSpecies : PokemonSpecies
	{
#nullable enable
		private static GothitaSpecies? _instance = null;
#nullable restore
        public static GothitaSpecies Instance => _instance ?? (_instance = new GothitaSpecies());

		#region GothitaSpecies Constructor
		public GothitaSpecies() : base(
			574,
			"Gothita",
			Psychic.Instance,
			0.4,
			5.8,
			new PokemonStats(
				45, // HPs
				30, 50, // Attack & Defense
				55, 65, // Spacial Attack & Defense
				45 // Speed
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
				"Pound",
				"Double-Slap",
				"Psybeam",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
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
				"Feint-Attack",
				"Charm",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Torment",
				"Flatter",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Fake-Tears",
				"Rock-Tomb",
				"Tickle",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Miracle-Eye",
				"Payback",
				"Embargo",
				"Fling",
				"Heal-Block",
				"Dark-Pulse",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Heal-Pulse",
				"Play-Nice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}