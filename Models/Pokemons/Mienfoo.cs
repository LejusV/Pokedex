using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mienfoo Species to store common natural stats of all Mienfoos
	#region SpeciesMienfoo
	public class SpeciesMienfoo : PokemonSpecies
	{
#nullable enable
		private static SpeciesMienfoo? _instance = null;
#nullable restore
        public static SpeciesMienfoo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMienfoo();
                }
                return _instance;
            }
        }

		#region SpeciesMienfoo Constructor
		public SpeciesMienfoo() : base(
			619,
			"Mienfoo",
			0.9,
			20.0,
			45, // HPs
			85, 50, // Attack & Defense
			55, 50, // Special Attack & Defense
			65		
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

	//Mienfoo PokemonInstance Class
	#region Mienfoo
	public class MienfooInstance : PokemonInstance
	{
		#region Mienfoo Constructors
		/// <summary>
		/// Mienfoo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MienfooInstance(string nickname, int level)
		: base(
				SpeciesMienfoo.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mienfoo Builder only waiting for a Level
		/// </summary>
		public MienfooInstance(int level)
		: base(
				SpeciesMienfoo.Instance, // PokemonInstance Species
				"Mienfoo", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mienfoo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MienfooInstance() : base(
			SpeciesMienfoo.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}