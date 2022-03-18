using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Houndoom Species to store common natural stats of all Houndooms
	#region SpeciesHoundoom
	public class SpeciesHoundoom : PokemonSpecies
	{
#nullable enable
		private static SpeciesHoundoom? _instance = null;
#nullable restore
        public static SpeciesHoundoom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHoundoom();
                }
                return _instance;
            }
        }

		#region SpeciesHoundoom Constructor
		public SpeciesHoundoom() : base(
			229,
			"Houndoom",
			1.4,
			35.0,
			75, // HPs
			90, 50, // Attack & Defense
			110, 80, // Special Attack & Defense
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Solar-Beam",
				"Toxic",
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
				"Spite",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
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
				"Payback",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
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

	//Houndoom PokemonInstance Class
	#region Houndoom
	public class HoundoomInstance : PokemonInstance
	{
		#region Houndoom Constructors
		/// <summary>
		/// Houndoom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HoundoomInstance(string nickname, int level)
		: base(
				SpeciesHoundoom.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Houndoom Builder only waiting for a Level
		/// </summary>
		public HoundoomInstance(int level)
		: base(
				SpeciesHoundoom.Instance, // PokemonInstance Species
				"Houndoom", level,
				Dark.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Houndoom Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HoundoomInstance() : base(
			SpeciesHoundoom.Instance, // PokemonInstance Species
			Dark.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}