using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Magby Species to store common natural stats of all Magbys
	#region SpeciesMagby
	public class SpeciesMagby : PokemonSpecies
	{
#nullable enable
		private static SpeciesMagby? _instance = null;
#nullable restore
        public static SpeciesMagby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMagby();
                }
                return _instance;
            }
        }

		#region SpeciesMagby Constructor
		public SpeciesMagby() : base(
			240,
			"Magby",
			0.7,
			21.4,
			45, // HPs
			75, 37, // Attack & Defense
			70, 55, // Special Attack & Defense
			83		
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
				"Karate-Chop",
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Ember",
				"Flamethrower",
				"Counter",
				"Seismic-Toss",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Smokescreen",
				"Confuse-Ray",
				"Barrier",
				"Focus-Energy",
				"Smog",
				"Fire-Blast",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mach-Punch",
				"Feint-Attack",
				"Belly-Drum",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Cross-Chop",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Overheat",
				"Covet",
				"Natural-Gift",
				"Fling",
				"Power-Swap",
				"Flare-Blitz",
				"Lava-Plume",
				"Captivate",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Clear-Smog",
				"Incinerate",
				"Dual-Chop",
				"Belch",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Magby PokemonInstance Class
	#region Magby
	public class MagbyInstance : PokemonInstance
	{
		#region Magby Constructors
		/// <summary>
		/// Magby Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MagbyInstance(string nickname, int level)
		: base(
				SpeciesMagby.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magby Builder only waiting for a Level
		/// </summary>
		public MagbyInstance(int level)
		: base(
				SpeciesMagby.Instance, // PokemonInstance Species
				"Magby", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magby Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MagbyInstance() : base(
			SpeciesMagby.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}