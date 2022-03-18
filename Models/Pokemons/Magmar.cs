using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Magmar Species to store common natural stats of all Magmars
	#region SpeciesMagmar
	public class SpeciesMagmar : PokemonSpecies
	{
#nullable enable
		private static SpeciesMagmar? _instance = null;
#nullable restore
        public static SpeciesMagmar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMagmar();
                }
                return _instance;
            }
        }

		#region SpeciesMagmar Constructor
		public SpeciesMagmar() : base(
			126,
			"Magmar",
			1.3,
			44.5,
			65, // HPs
			95, 57, // Attack & Defense
			100, 85, // Special Attack & Defense
			93		
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
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Confuse-Ray",
				"Bide",
				"Metronome",
				"Smog",
				"Fire-Blast",
				"Skull-Bash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
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
				"Sunny-Day",
				"Rock-Smash",
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
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Lava-Plume",
				"Captivate",
				"Flame-Burst",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Clear-Smog",
				"Incinerate",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Magmar PokemonInstance Class
	#region Magmar
	public class MagmarInstance : PokemonInstance
	{
		#region Magmar Constructors
		/// <summary>
		/// Magmar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MagmarInstance(string nickname, int level)
		: base(
				SpeciesMagmar.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magmar Builder only waiting for a Level
		/// </summary>
		public MagmarInstance(int level)
		: base(
				SpeciesMagmar.Instance, // PokemonInstance Species
				"Magmar", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magmar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MagmarInstance() : base(
			SpeciesMagmar.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}