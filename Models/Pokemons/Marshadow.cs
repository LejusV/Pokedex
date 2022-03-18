using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Marshadow Species to store common natural stats of all Marshadows
	#region SpeciesMarshadow
	public class SpeciesMarshadow : PokemonSpecies
	{
#nullable enable
		private static SpeciesMarshadow? _instance = null;
#nullable restore
        public static SpeciesMarshadow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMarshadow();
                }
                return _instance;
            }
        }

		#region SpeciesMarshadow Constructor
		public SpeciesMarshadow() : base(
			802,
			"Marshadow",
			0.7,
			22.2,
			90, // HPs
			125, 80, // Attack & Defense
			90, 90, // Special Attack & Defense
			125		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Jump-Kick",
				"Rolling-Kick",
				"Counter",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Protect",
				"False-Swipe",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Psych-Up",
				"Shadow-Ball",
				"Will-O-Wisp",
				"Facade",
				"Role-Play",
				"Brick-Break",
				"Endeavor",
				"Rock-Tomb",
				"Shadow-Punch",
				"Bulk-Up",
				"Calm-Mind",
				"Feint",
				"Close-Combat",
				"Payback",
				"Assurance",
				"Fling",
				"Copycat",
				"Sucker-Punch",
				"Force-Palm",
				"Poison-Jab",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Stone-Edge",
				"Grass-Knot",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Acrobatics",
				"Work-Up",
				"Confide",
				"Laser-Focus",
				"Spectral-Thief"
			};
		}
		#endregion
	}
	#endregion

	//Marshadow PokemonInstance Class
	#region Marshadow
	public class MarshadowInstance : PokemonInstance
	{
		#region Marshadow Constructors
		/// <summary>
		/// Marshadow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MarshadowInstance(string nickname, int level)
		: base(
				SpeciesMarshadow.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marshadow Builder only waiting for a Level
		/// </summary>
		public MarshadowInstance(int level)
		: base(
				SpeciesMarshadow.Instance, // PokemonInstance Species
				"Marshadow", level,
				Fighting.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marshadow Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MarshadowInstance() : base(
			SpeciesMarshadow.Instance, // PokemonInstance Species
			Fighting.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}