using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mienshao Species to store common natural stats of all Mienshaos
	#region MienshaoSpecies
	public class MienshaoSpecies : PokemonSpecies
	{
#nullable enable
		private static MienshaoSpecies? _instance = null;
#nullable restore
        public static MienshaoSpecies Instance => _instance ?? (_instance = new MienshaoSpecies());

		#region MienshaoSpecies Constructor
		public MienshaoSpecies() : base(
			620,
			"Mienshao",
			Fighting.Instance,
			1.4,
			35.5,
			new PokemonStats(
				65, // HPs
				125, 60, // Attack & Defense
				95, 60, // Spacial Attack & Defense
				105 // Speed
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
				"Swords-Dance",
				"Jump-Kick",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Meditate",
				"Double-Team",
				"Reflect",
				"Swift",
				"High-Jump-Kick",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Detect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Rock-Smash",
				"Fake-Out",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Bounce",
				"Calm-Mind",
				"U-Turn",
				"Payback",
				"Fling",
				"Force-Palm",
				"Aura-Sphere",
				"Poison-Jab",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Stone-Edge",
				"Grass-Knot",
				"Wide-Guard",
				"Low-Sweep",
				"Round",
				"Acrobatics",
				"Retaliate",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}