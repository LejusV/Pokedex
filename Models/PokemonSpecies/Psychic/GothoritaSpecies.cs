using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gothorita Species to store common natural stats of all Gothoritas
	#region GothoritaSpecies
	public class GothoritaSpecies : PokemonSpecies
	{
#nullable enable
		private static GothoritaSpecies? _instance = null;
#nullable restore
        public static GothoritaSpecies Instance => _instance ?? (_instance = new GothoritaSpecies());

		#region GothoritaSpecies Constructor
		public GothoritaSpecies() : base(
			575,
			"Gothorita",
			Psychic.Instance,
			0.7,
			18.0,
			new PokemonStats(
				60, // HPs
				45, 70, // Attack & Defense
				75, 85, // Spacial Attack & Defense
				55 // Speed
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
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
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
				"Payback",
				"Embargo",
				"Fling",
				"Heal-Block",
				"Dark-Pulse",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Play-Nice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}