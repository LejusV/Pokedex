using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Darumaka Species to store common natural stats of all Darumakas
	#region SpeciesDarumaka
	public class SpeciesDarumaka : PokemonSpecies
	{
#nullable enable
		private static SpeciesDarumaka? _instance = null;
#nullable restore
        public static SpeciesDarumaka Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDarumaka();
                }
                return _instance;
            }
        }

		#region SpeciesDarumaka Constructor
		public SpeciesDarumaka() : base(
			554,
			"Darumaka",
			0.6,
			37.5,
			70, // HPs
			90, 45, // Attack & Defense
			15, 45, // Special Attack & Defense
			50		
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
				"Take-Down",
				"Thrash",
				"Roar",
				"Flamethrower",
				"Strength",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Rage",
				"Double-Team",
				"Focus-Energy",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Flame-Wheel",
				"Snore",
				"Protect",
				"Belly-Drum",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Yawn",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Extrasensory",
				"Hammer-Arm",
				"Gyro-Ball",
				"U-Turn",
				"Fling",
				"Flare-Blitz",
				"Fire-Fang",
				"Zen-Headbutt",
				"Grass-Knot",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Darumaka PokemonInstance Class
	#region Darumaka
	public class DarumakaInstance : PokemonInstance
	{
		#region Darumaka Constructors
		/// <summary>
		/// Darumaka Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DarumakaInstance(string nickname, int level)
		: base(
				SpeciesDarumaka.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darumaka Builder only waiting for a Level
		/// </summary>
		public DarumakaInstance(int level)
		: base(
				SpeciesDarumaka.Instance, // PokemonInstance Species
				"Darumaka", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darumaka Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DarumakaInstance() : base(
			SpeciesDarumaka.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}