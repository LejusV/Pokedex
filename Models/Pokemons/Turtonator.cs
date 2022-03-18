using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Turtonator Species to store common natural stats of all Turtonators
	#region SpeciesTurtonator
	public class SpeciesTurtonator : PokemonSpecies
	{
#nullable enable
		private static SpeciesTurtonator? _instance = null;
#nullable restore
        public static SpeciesTurtonator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTurtonator();
                }
                return _instance;
            }
        }

		#region SpeciesTurtonator Constructor
		public SpeciesTurtonator() : base(
			776,
			"Turtonator",
			2.0,
			212.0,
			60, // HPs
			78, 135, // Attack & Defense
			91, 85, // Special Attack & Defense
			36		
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
				"Tackle",
				"Body-Slam",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Fire-Spin",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Smog",
				"Fire-Blast",
				"Explosion",
				"Rest",
				"Substitute",
				"Flail",
				"Protect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Revenge",
				"Overheat",
				"Rock-Tomb",
				"Iron-Defense",
				"Dragon-Claw",
				"Bulk-Up",
				"Payback",
				"Fling",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Flash-Cannon",
				"Draco-Meteor",
				"Stone-Edge",
				"Charge-Beam",
				"Head-Smash",
				"Wide-Guard",
				"Venoshock",
				"Smack-Down",
				"Flame-Charge",
				"Round",
				"Shell-Smash",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Confide",
				"Brutal-Swing",
				"Shell-Trap"
			};
		}
		#endregion
	}
	#endregion

	//Turtonator PokemonInstance Class
	#region Turtonator
	public class TurtonatorInstance : PokemonInstance
	{
		#region Turtonator Constructors
		/// <summary>
		/// Turtonator Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TurtonatorInstance(string nickname, int level)
		: base(
				SpeciesTurtonator.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Turtonator Builder only waiting for a Level
		/// </summary>
		public TurtonatorInstance(int level)
		: base(
				SpeciesTurtonator.Instance, // PokemonInstance Species
				"Turtonator", level,
				Fire.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Turtonator Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TurtonatorInstance() : base(
			SpeciesTurtonator.Instance, // PokemonInstance Species
			Fire.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}