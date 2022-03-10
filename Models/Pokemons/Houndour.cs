using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Houndour Species to store common natural stats of all Houndours
	#region SpeciesHoundour
	public class SpeciesHoundour : PokemonSpecies
	{
#nullable enable
		private static SpeciesHoundour? _instance = null;
#nullable restore
        public static SpeciesHoundour Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHoundour();
                }
                return _instance;
            }
        }

		#region SpeciesHoundour Constructor
		public SpeciesHoundour() : base(
			"Houndour",
			0.6,
			10.8,
			45, // HPs
			60, 30, // Attack & Defense
			80, 50, // Special Attack & Defense
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Counter",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Smog",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Reversal",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Destiny-Bond",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Beat-Up",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Role-Play",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Odor-Sleuth",
				"Howl",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Embargo",
				"Punishment",
				"Sucker-Punch",
				"Dark-Pulse",
				"Nasty-Plot",
				"Thunder-Fang",
				"Fire-Fang",
				"Captivate",
				"Flame-Charge",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Inferno",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Houndour PokemonInstance Class
	#region Houndour
	public class HoundourInstance : PokemonInstance
	{
		#region Houndour Constructors
		/// <summary>
		/// Houndour Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HoundourInstance(string nickname, int level)
		: base(
				228,
				SpeciesHoundour.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Houndour Builder only waiting for a Level
		/// </summary>
		public HoundourInstance(int level)
		: base(
				228,
				SpeciesHoundour.Instance, // PokemonInstance Species
				"Houndour", level,
				Dark.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Houndour Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Houndour() : base(
			228,
			SpeciesHoundour.Instance, // PokemonInstance Species
			Dark.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}