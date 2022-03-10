using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Quilava Species to store common natural stats of all Quilavas
	#region SpeciesQuilava
	public class SpeciesQuilava : PokemonSpecies
	{
#nullable enable
		private static SpeciesQuilava? _instance = null;
#nullable restore
        public static SpeciesQuilava Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesQuilava();
                }
                return _instance;
            }
        }

		#region SpeciesQuilava Constructor
		public SpeciesQuilava() : base(
			"Quilava",
			0.9,
			19.0,
			58, // HPs
			64, 58, // Attack & Defense
			80, 65, // Special Attack & Defense
			80		
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
				"Cut",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Roar",
				"Ember",
				"Flamethrower",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Defense-Curl",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Brick-Break",
				"Eruption",
				"Secret-Power",
				"Overheat",
				"Aerial-Ace",
				"Covet",
				"Natural-Gift",
				"Lava-Plume",
				"Captivate",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Inferno",
				"Fire-Pledge",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Burn-Up"
			};
		}
		#endregion
	}
	#endregion

	//Quilava PokemonInstance Class
	#region Quilava
	public class QuilavaInstance : PokemonInstance
	{
		#region Quilava Constructors
		/// <summary>
		/// Quilava Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public QuilavaInstance(string nickname, int level)
		: base(
				156,
				SpeciesQuilava.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quilava Builder only waiting for a Level
		/// </summary>
		public QuilavaInstance(int level)
		: base(
				156,
				SpeciesQuilava.Instance, // PokemonInstance Species
				"Quilava", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quilava Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Quilava() : base(
			156,
			SpeciesQuilava.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}