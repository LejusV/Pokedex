using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mienshao Species to store common natural stats of all Mienshaos
	#region SpeciesMienshao
	public class SpeciesMienshao : PokemonSpecies
	{
#nullable enable
		private static SpeciesMienshao? _instance = null;
#nullable restore
        public static SpeciesMienshao Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMienshao();
                }
                return _instance;
            }
        }

		#region SpeciesMienshao Constructor
		public SpeciesMienshao() : base(
			"Mienshao",
			1.4,
			35.5,
			65, // HPs
			125, 60, // Attack & Defense
			95, 60, // Special Attack & Defense
			105		
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

	//Mienshao PokemonInstance Class
	#region Mienshao
	public class MienshaoInstance : PokemonInstance
	{
		#region Mienshao Constructors
		/// <summary>
		/// Mienshao Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MienshaoInstance(string nickname, int level)
		: base(
				620,
				SpeciesMienshao.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mienshao Builder only waiting for a Level
		/// </summary>
		public MienshaoInstance(int level)
		: base(
				620,
				SpeciesMienshao.Instance, // PokemonInstance Species
				"Mienshao", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mienshao Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Mienshao() : base(
			620,
			SpeciesMienshao.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}