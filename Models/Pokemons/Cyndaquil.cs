using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cyndaquil Species to store common natural stats of all Cyndaquils
	#region SpeciesCyndaquil
	public class SpeciesCyndaquil : PokemonSpecies
	{
#nullable enable
		private static SpeciesCyndaquil? _instance = null;
#nullable restore
        public static SpeciesCyndaquil Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCyndaquil();
                }
                return _instance;
            }
        }

		#region SpeciesCyndaquil Constructor
		public SpeciesCyndaquil() : base(
			"Cyndaquil",
			0.5,
			7.9,
			39, // HPs
			52, 43, // Attack & Defense
			60, 50, // Special Attack & Defense
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
				"Cut",
				"Double-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Ember",
				"Flamethrower",
				"Submission",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Defense-Curl",
				"Fire-Blast",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Eruption",
				"Secret-Power",
				"Crush-Claw",
				"Overheat",
				"Extrasensory",
				"Aerial-Ace",
				"Howl",
				"Covet",
				"Natural-Gift",
				"Flare-Blitz",
				"Lava-Plume",
				"Captivate",
				"Flame-Burst",
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

	//Cyndaquil PokemonInstance Class
	#region Cyndaquil
	public class CyndaquilInstance : PokemonInstance
	{
		#region Cyndaquil Constructors
		/// <summary>
		/// Cyndaquil Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CyndaquilInstance(string nickname, int level)
		: base(
				155,
				SpeciesCyndaquil.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cyndaquil Builder only waiting for a Level
		/// </summary>
		public CyndaquilInstance(int level)
		: base(
				155,
				SpeciesCyndaquil.Instance, // PokemonInstance Species
				"Cyndaquil", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cyndaquil Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Cyndaquil() : base(
			155,
			SpeciesCyndaquil.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}