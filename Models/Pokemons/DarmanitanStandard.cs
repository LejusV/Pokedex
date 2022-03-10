using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Darmanitan-Standard Species to store common natural stats of all Darmanitan-Standards
	#region SpeciesDarmanitan-Standard
	public class SpeciesDarmanitanStandard : PokemonSpecies
	{
#nullable enable
		private static SpeciesDarmanitanStandard? _instance = null;
#nullable restore
        public static SpeciesDarmanitanStandard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDarmanitanStandard();
                }
                return _instance;
            }
        }

		#region SpeciesDarmanitan-Standard Constructor
		public SpeciesDarmanitanStandard() : base(
			"Darmanitan-Standard",
			1.3,
			92.9,
			105, // HPs
			140, 55, // Attack & Defense
			30, 55, // Special Attack & Defense
			95		
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
				"Headbutt",
				"Tackle",
				"Thrash",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Psychic",
				"Rage",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Belly-Drum",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Bulk-Up",
				"Hammer-Arm",
				"Gyro-Ball",
				"U-Turn",
				"Payback",
				"Fling",
				"Flare-Blitz",
				"Focus-Blast",
				"Giga-Impact",
				"Fire-Fang",
				"Zen-Headbutt",
				"Stone-Edge",
				"Grass-Knot",
				"Smack-Down",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Darmanitan-Standard PokemonInstance Class
	#region Darmanitan-Standard
	public class DarmanitanStandardInstance : PokemonInstance
	{
		#region Darmanitan-Standard Constructors
		/// <summary>
		/// Darmanitan-Standard Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DarmanitanStandardInstance(string nickname, int level)
		: base(
				555,
				SpeciesDarmanitanStandard.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darmanitan-Standard Builder only waiting for a Level
		/// </summary>
		public DarmanitanStandardInstance(int level)
		: base(
				555,
				SpeciesDarmanitanStandard.Instance, // PokemonInstance Species
				"Darmanitan-Standard", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darmanitan-Standard Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DarmanitanStandard() : base(
			555,
			SpeciesDarmanitanStandard.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}