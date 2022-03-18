using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Typhlosion Species to store common natural stats of all Typhlosions
	#region SpeciesTyphlosion
	public class SpeciesTyphlosion : PokemonSpecies
	{
#nullable enable
		private static SpeciesTyphlosion? _instance = null;
#nullable restore
        public static SpeciesTyphlosion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTyphlosion();
                }
                return _instance;
            }
        }

		#region SpeciesTyphlosion Constructor
		public SpeciesTyphlosion() : base(
			157,
			"Typhlosion",
			1.7,
			79.5,
			78, // HPs
			84, 78, // Attack & Defense
			109, 85, // Special Attack & Defense
			100		
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
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Earthquake",
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
				"Rock-Slide",
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
				"Dynamic-Punch",
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
				"Blast-Burn",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Covet",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Rock-Climb",
				"Lava-Plume",
				"Captivate",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Inferno",
				"Fire-Pledge",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Power-Up-Punch",
				"Burn-Up"
			};
		}
		#endregion
	}
	#endregion

	//Typhlosion PokemonInstance Class
	#region Typhlosion
	public class TyphlosionInstance : PokemonInstance
	{
		#region Typhlosion Constructors
		/// <summary>
		/// Typhlosion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TyphlosionInstance(string nickname, int level)
		: base(
				SpeciesTyphlosion.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Typhlosion Builder only waiting for a Level
		/// </summary>
		public TyphlosionInstance(int level)
		: base(
				SpeciesTyphlosion.Instance, // PokemonInstance Species
				"Typhlosion", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Typhlosion Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TyphlosionInstance() : base(
			SpeciesTyphlosion.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}