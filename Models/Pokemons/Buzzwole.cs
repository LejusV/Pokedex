using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Buzzwole Species to store common natural stats of all Buzzwoles
	#region SpeciesBuzzwole
	public class SpeciesBuzzwole : PokemonSpecies
	{
#nullable enable
		private static SpeciesBuzzwole? _instance = null;
#nullable restore
        public static SpeciesBuzzwole Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBuzzwole();
                }
                return _instance;
            }
        }

		#region SpeciesBuzzwole Constructor
		public SpeciesBuzzwole() : base(
			794,
			"Buzzwole",
			2.4,
			333.6,
			107, // HPs
			139, 139, // Attack & Defense
			53, 53, // Special Attack & Defense
			79		
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
				"Comet-Punch",
				"Mega-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Counter",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Harden",
				"Focus-Energy",
				"Leech-Life",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Reversal",
				"Protect",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Vital-Throw",
				"Hidden-Power",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Rock-Tomb",
				"Bulk-Up",
				"Roost",
				"Hammer-Arm",
				"Gyro-Ball",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Giga-Impact",
				"Stone-Edge",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Work-Up",
				"Fell-Stinger",
				"Confide",
				"Power-Up-Punch",
				"Lunge"
			};
		}
		#endregion
	}
	#endregion

	//Buzzwole PokemonInstance Class
	#region Buzzwole
	public class BuzzwoleInstance : PokemonInstance
	{
		#region Buzzwole Constructors
		/// <summary>
		/// Buzzwole Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BuzzwoleInstance(string nickname, int level)
		: base(
				SpeciesBuzzwole.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buzzwole Builder only waiting for a Level
		/// </summary>
		public BuzzwoleInstance(int level)
		: base(
				SpeciesBuzzwole.Instance, // PokemonInstance Species
				"Buzzwole", level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buzzwole Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BuzzwoleInstance() : base(
			SpeciesBuzzwole.Instance, // PokemonInstance Species
			Bug.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}