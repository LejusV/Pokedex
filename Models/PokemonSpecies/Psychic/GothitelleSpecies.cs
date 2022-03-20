using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gothitelle Species to store common natural stats of all Gothitelles
	#region GothitelleSpecies
	public class GothitelleSpecies : PokemonSpecies
	{
#nullable enable
		private static GothitelleSpecies? _instance = null;
#nullable restore
        public static GothitelleSpecies Instance => _instance ?? (_instance = new GothitelleSpecies());

		#region GothitelleSpecies Constructor
		public GothitelleSpecies() : base(
			576,
			"Gothitelle",
			Psychic.Instance,
			1.5,
			44.0,
			new PokemonStats(
				70, // HPs
				55, 95, // Attack & Defense
				95, 110, // Spacial Attack & Defense
				65 // Speed
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
				"Hyper-Beam",
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
				"Brick-Break",
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
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Play-Nice",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}