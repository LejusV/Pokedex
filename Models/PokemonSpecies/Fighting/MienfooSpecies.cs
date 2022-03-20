using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mienfoo Species to store common natural stats of all Mienfoos
	#region MienfooSpecies
	public class MienfooSpecies : PokemonSpecies
	{
#nullable enable
		private static MienfooSpecies? _instance = null;
#nullable restore
        public static MienfooSpecies Instance => _instance ?? (_instance = new MienfooSpecies());

		#region MienfooSpecies Constructor
		public MienfooSpecies() : base(
			619,
			"Mienfoo",
			Fighting.Instance,
			0.9,
			20.0,
			new PokemonStats(
				45, // HPs
				85, 50, // Attack & Defense
				55, 50, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Jump-Kick",
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
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Vital-Throw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Rock-Smash",
				"Fake-Out",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
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
				"Feint",
				"U-Turn",
				"Payback",
				"Fling",
				"Me-First",
				"Force-Palm",
				"Aura-Sphere",
				"Poison-Jab",
				"Drain-Punch",
				"Focus-Blast",
				"Stone-Edge",
				"Grass-Knot",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Ally-Switch",
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