using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hoopa Species to store common natural stats of all Hoopas
	#region SpeciesHoopa
	public class SpeciesHoopa : PokemonSpecies
	{
#nullable enable
		private static SpeciesHoopa? _instance = null;
#nullable restore
        public static SpeciesHoopa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHoopa();
                }
                return _instance;
            }
        }

		#region SpeciesHoopa Constructor
		public SpeciesHoopa() : base(
			"Hoopa",
			0.5,
			9.0,
			80, // HPs
			110, 60, // Attack & Defense
			150, 130, // Special Attack & Defense
			70		
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
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Destiny-Bond",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Signal-Beam",
				"Block",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Embargo",
				"Fling",
				"Last-Resort",
				"Dark-Pulse",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Gunk-Shot",
				"Grass-Knot",
				"Charge-Beam",
				"Guard-Split",
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Ally-Switch",
				"Quash",
				"Dual-Chop",
				"Phantom-Force",
				"Confide",
				"Hyperspace-Hole",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Hoopa PokemonInstance Class
	#region Hoopa
	public class HoopaInstance : PokemonInstance
	{
		#region Hoopa Constructors
		/// <summary>
		/// Hoopa Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HoopaInstance(string nickname, int level)
		: base(
				720,
				SpeciesHoopa.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoopa Builder only waiting for a Level
		/// </summary>
		public HoopaInstance(int level)
		: base(
				720,
				SpeciesHoopa.Instance, // PokemonInstance Species
				"Hoopa", level,
				Psychic.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoopa Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Hoopa() : base(
			720,
			SpeciesHoopa.Instance, // PokemonInstance Species
			Psychic.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}